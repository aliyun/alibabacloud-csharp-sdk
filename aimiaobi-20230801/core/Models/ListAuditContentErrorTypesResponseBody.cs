// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListAuditContentErrorTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of audit dimensions</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAuditContentErrorTypesResponseBodyData> Data { get; set; }
        public class ListAuditContentErrorTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Main audit dimension code</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContentAccuracy</para>
            /// </summary>
            [NameInMap("MajorClassCode")]
            [Validation(Required=false)]
            public string MajorClassCode { get; set; }

            /// <summary>
            /// <para>Sub-audit dimension name</para>
            /// 
            /// <b>Example:</b>
            /// <para>内容准确性</para>
            /// </summary>
            [NameInMap("MajorClassName")]
            [Validation(Required=false)]
            public string MajorClassName { get; set; }

            /// <summary>
            /// <para>List of sub-audit dimensions</para>
            /// </summary>
            [NameInMap("SubClasses")]
            [Validation(Required=false)]
            public List<ListAuditContentErrorTypesResponseBodyDataSubClasses> SubClasses { get; set; }
            public class ListAuditContentErrorTypesResponseBodyDataSubClasses : TeaModel {
                /// <summary>
                /// <para>Sub-audit dimension code</para>
                /// 
                /// <b>Example:</b>
                /// <para>PunctuationError</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                /// <summary>
                /// <para>Sub-audit dimension name</para>
                /// 
                /// <b>Example:</b>
                /// <para>标点符号错误</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Maximum number of records returned in this response</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Token for the next page</para>
        /// 
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
