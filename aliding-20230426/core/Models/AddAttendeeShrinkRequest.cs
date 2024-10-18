// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AddAttendeeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AttendeesToAdd")]
        [Validation(Required=false)]
        public string AttendeesToAddShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cnNTbW1YbU9sL2p6aFJZdEgvdlQrQT08</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("chatNotification")]
        [Validation(Required=false)]
        public bool? ChatNotification { get; set; }

        [NameInMap("pushNotification")]
        [Validation(Required=false)]
        public bool? PushNotification { get; set; }

    }

}
