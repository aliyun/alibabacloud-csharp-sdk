// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOperationLogPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, default value is 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeOperationLogPageListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeOperationLogPageListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Client IP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.68.***.166</para>
            /// </summary>
            [NameInMap("clientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Content after operation</para>
            /// 
            /// <b>Example:</b>
            /// <para>@selfvariable_02</para>
            /// </summary>
            [NameInMap("newContent")]
            [Validation(Required=false)]
            public string NewContent { get; set; }

            /// <summary>
            /// <para>Content before operation</para>
            /// 
            /// <b>Example:</b>
            /// <para>@selfvariable_02 + 1001</para>
            /// </summary>
            [NameInMap("oldContent")]
            [Validation(Required=false)]
            public string OldContent { get; set; }

            /// <summary>
            /// <para>Operation summary</para>
            /// 
            /// <b>Example:</b>
            /// <para>更新事件:决策引擎可观测性持续建设_事件A(de_afghcf6411)</para>
            /// </summary>
            [NameInMap("operationSummary")]
            [Validation(Required=false)]
            public string OperationSummary { get; set; }

            /// <summary>
            /// <para>Operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_EVENT</para>
            /// </summary>
            [NameInMap("operationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>Operator</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>Total number of items</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
