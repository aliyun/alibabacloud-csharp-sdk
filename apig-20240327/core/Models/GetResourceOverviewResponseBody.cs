// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetResourceOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>Response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Resource information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetResourceOverviewResponseBodyData Data { get; set; }
        public class GetResourceOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>API information.</para>
            /// </summary>
            [NameInMap("api")]
            [Validation(Required=false)]
            public GetResourceOverviewResponseBodyDataApi Api { get; set; }
            public class GetResourceOverviewResponseBodyDataApi : TeaModel {
                /// <summary>
                /// <para>Number of published APIs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("publishedCount")]
                [Validation(Required=false)]
                public long? PublishedCount { get; set; }

                /// <summary>
                /// <para>Number of APIs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>Gateway information.</para>
            /// </summary>
            [NameInMap("gateway")]
            [Validation(Required=false)]
            public GetResourceOverviewResponseBodyDataGateway Gateway { get; set; }
            public class GetResourceOverviewResponseBodyDataGateway : TeaModel {
                /// <summary>
                /// <para>Number of running gateways.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("runningCount")]
                [Validation(Required=false)]
                public long? RunningCount { get; set; }

                /// <summary>
                /// <para>Number of gateway instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD19A442-93C5-5C97-AFA0-B9C57EBD781B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
