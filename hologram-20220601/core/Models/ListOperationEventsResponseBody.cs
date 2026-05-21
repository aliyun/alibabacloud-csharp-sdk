// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListOperationEventsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOperationEventsResponseBodyData> Data { get; set; }
        public class ListOperationEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Cancelable")]
            [Validation(Required=false)]
            public bool? Cancelable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChangeScheduleTime")]
            [Validation(Required=false)]
            public bool? ChangeScheduleTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HOT_UPGRADE</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UPGRADE_ON_CUSTOMERS_BEHALF</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("FollowerInstances")]
            [Validation(Required=false)]
            public List<ListOperationEventsResponseBodyDataFollowerInstances> FollowerInstances { get; set; }
            public class ListOperationEventsResponseBodyDataFollowerInstances : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>hgxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hi</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

            }

            /// <summary>
            /// <para>Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>1826503661244379138</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>haha</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21:00-22:00</para>
            /// </summary>
            [NameInMap("MaintainWindow")]
            [Validation(Required=false)]
            public string MaintainWindow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hgpost-cn-sxfsdfsd</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>ScheduleTime</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-22 15:49:28</para>
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            /// <summary>
            /// <para>State</para>
            /// 
            /// <b>Example:</b>
            /// <para>queued</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D3AE84AB-0873-5FC7-A4C4-8CF869D2FA70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
