// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAllCallbackResponseBody : TeaModel {
        [NameInMap("Callbacks")]
        [Validation(Required=false)]
        public List<DescribeAllCallbackResponseBodyCallbacks> Callbacks { get; set; }
        public class DescribeAllCallbackResponseBodyCallbacks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RecordEvent</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>录制回调</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SubEvent")]
            [Validation(Required=false)]
            public List<DescribeAllCallbackResponseBodyCallbacksSubEvent> SubEvent { get; set; }
            public class DescribeAllCallbackResponseBodyCallbacksSubEvent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("Event")]
                [Validation(Required=false)]
                public int? Event { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>录制开始</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
