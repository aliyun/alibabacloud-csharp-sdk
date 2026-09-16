// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListLumaNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates a successful call. A specific error code is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of namespaces bound to the Agent. All results are returned at once without pagination.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLumaNamespacesResponseBodyData Data { get; set; }
        public class ListLumaNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>本次请求实际生效的每页数量。未传 Limit 时为服务端默认值，超出上限时为收敛后的值</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

            /// <summary>
            /// <para>The list of namespaces bound to the Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Name&quot;:&quot;my_namespace&quot;}]</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<Namespace> Namespaces { get; set; }

            /// <summary>
            /// <para>下一页起始Token，传入下次请求的 NextToken 可获取下一页；为空表示已无更多数据</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>Agent 绑定的命名空间总数，与本页返回条数无关</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value is Operation success when the call succeeds, or a specific error description when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting and ticket feedback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
