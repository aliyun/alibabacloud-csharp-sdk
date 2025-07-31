// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiImpactsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServiceApiImpactsResponseBodyPageResult PageResult { get; set; }
        public class ListDataServiceApiImpactsResponseBodyPageResult : TeaModel {
            [NameInMap("ImpactList")]
            [Validation(Required=false)]
            public List<ListDataServiceApiImpactsResponseBodyPageResultImpactList> ImpactList { get; set; }
            public class ListDataServiceApiImpactsResponseBodyPageResultImpactList : TeaModel {
                /// <summary>
                /// <para>apiNo</para>
                /// 
                /// <b>Example:</b>
                /// <para>2011</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <para>appKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>1101</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public long? AppKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public long? CallCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ClientFailCount")]
                [Validation(Required=false)]
                public long? ClientFailCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorApiCount")]
                [Validation(Required=false)]
                public long? ErrorApiCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorCount")]
                [Validation(Required=false)]
                public long? ErrorCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("ErrorRate")]
                [Validation(Required=false)]
                public string ErrorRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 08:00:00</para>
                /// </summary>
                [NameInMap("LastCallTime")]
                [Validation(Required=false)]
                public string LastCallTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025_0611_1011</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public string Minute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OfflineCount")]
                [Validation(Required=false)]
                public long? OfflineCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("SuccessTimeCost")]
                [Validation(Required=false)]
                public string SuccessTimeCost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>88</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>231</para>
                /// </summary>
                [NameInMap("TotalTimeCost")]
                [Validation(Required=false)]
                public string TotalTimeCost { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
