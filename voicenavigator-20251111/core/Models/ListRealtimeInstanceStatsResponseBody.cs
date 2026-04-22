// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListRealtimeInstanceStatsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRealtimeInstanceStatsResponseBodyData Data { get; set; }
        public class ListRealtimeInstanceStatsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListRealtimeInstanceStatsResponseBodyDataList> List { get; set; }
            public class ListRealtimeInstanceStatsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("ConfiguredConcurrency")]
                [Validation(Required=false)]
                public long? ConfiguredConcurrency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>88b64330a8d34e63b60c9d272f8b3950</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1776837256000</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("UsedConcurrency")]
                [Validation(Required=false)]
                public long? UsedConcurrency { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DB8BA95-4513-54B9-9C67-A28909CFB4AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
