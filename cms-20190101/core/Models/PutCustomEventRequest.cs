// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomEventRequest : TeaModel {
        /// <summary>
        /// <para>The list of event information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventInfo")]
        [Validation(Required=false)]
        public List<PutCustomEventRequestEventInfo> EventInfo { get; set; }
        public class PutCustomEventRequestEventInfo : TeaModel {
            /// <summary>
            /// <para>The event content. Valid values of N: 1 to 50.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IOException</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The event name. Valid values of N: 1 to 50.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myEvent</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The ID of the application group. Valid values of N: 0 to 50.</para>
            /// <para>Default value: 0. A value of 0 indicates that the reported event does not belong to any application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The time when the event occurred. Valid values of N: 1 to 50.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20171013T170923.456+0800</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
