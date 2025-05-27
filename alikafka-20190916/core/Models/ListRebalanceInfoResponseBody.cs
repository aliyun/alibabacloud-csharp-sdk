// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ListRebalanceInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRebalanceInfoResponseBodyData Data { get; set; }
        public class ListRebalanceInfoResponseBodyData : TeaModel {
            [NameInMap("RebalanceInfoList")]
            [Validation(Required=false)]
            public List<ListRebalanceInfoResponseBodyDataRebalanceInfoList> RebalanceInfoList { get; set; }
            public class ListRebalanceInfoResponseBodyDataRebalanceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Generation")]
                [Validation(Required=false)]
                public long? Generation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kafka-test</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1709199270</para>
                /// </summary>
                [NameInMap("LastRebalanceTimestamp")]
                [Validation(Required=false)]
                public long? LastRebalanceTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>removing member consumer-1-cd14eb9c-379b-4b8e-9bbd-76f147f8536f on LeaveGroup</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RebalanceSuccess")]
                [Validation(Required=false)]
                public bool? RebalanceSuccess { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("RebalanceTimeConsuming")]
                [Validation(Required=false)]
                public long? RebalanceTimeConsuming { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>06084011-E093-46F3-A51F-4B19A8AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
