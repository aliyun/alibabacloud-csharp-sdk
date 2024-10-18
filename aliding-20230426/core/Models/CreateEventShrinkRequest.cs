// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateEventShrinkRequest : TeaModel {
        [NameInMap("Attendees")]
        [Validation(Required=false)]
        public string AttendeesShrink { get; set; }

        [NameInMap("CardInstances")]
        [Validation(Required=false)]
        public string CardInstancesShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public string EndShrink { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAllDay")]
        [Validation(Required=false)]
        public bool? IsAllDay { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string LocationShrink { get; set; }

        [NameInMap("OnlineMeetingInfo")]
        [Validation(Required=false)]
        public string OnlineMeetingInfoShrink { get; set; }

        [NameInMap("Recurrence")]
        [Validation(Required=false)]
        public string RecurrenceShrink { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Reminders")]
        [Validation(Required=false)]
        public string RemindersShrink { get; set; }

        [NameInMap("RichTextDescription")]
        [Validation(Required=false)]
        public string RichTextDescriptionShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("UiConfigs")]
        [Validation(Required=false)]
        public string UiConfigsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("calendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public string StartShrink { get; set; }

    }

}
