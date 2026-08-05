// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ListFunctionRestrictionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not found</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>The execution duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.444</para>
        /// </summary>
        [NameInMap("latency")]
        [Validation(Required=false)]
        public double? Latency { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;xx not found&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2423C841-91C4-5E51-B296-590D367967FC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListFunctionRestrictionsResponseBodyResult> Result { get; set; }
        public class ListFunctionRestrictionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///                     &quot;taskType&quot;:&quot;text-embedding&quot;,
            ///                     &quot;modelSource&quot;:[
            ///                         &quot;ai_search&quot;
            ///                     ],
            ///                     &quot;regionId&quot;:[
            ///                         &quot;cn-hangzhou&quot;,
            ///                         &quot;cn-zhangjiakou&quot;
            ///                     ],
            ///                     &quot;instanceType&quot;:[
            ///                         &quot;gpu.v100.16g.x1&quot;,
            ///                         &quot;gpu.t4.16g.x1&quot;,
            ///                         &quot;gpu.a10.24g.x1&quot;
            ///                     ]
            ///                 }</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public Dictionary<string, object> Meta { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The request status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
