﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using ContosoNotes.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ContosoNotes.UI
{
    public class NoteItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TextItemTemplate { get; set; }

        public DataTemplate TaskItemTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is NoteItemModel noteItem)
            {
                if (noteItem is TaskNoteItemModel)
                {
                    return TaskItemTemplate;
                }
                else
                {
                    return TextItemTemplate;
                }
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
