// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListAuditContentErrorTypesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAuditContentErrorTypesResponseBodyData> Data { get; set; }
        public class ListAuditContentErrorTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ContentAccuracy</para>
            /// </summary>
            [NameInMap("MajorClassCode")]
            [Validation(Required=false)]
            public string MajorClassCode { get; set; }

            [NameInMap("MajorClassName")]
            [Validation(Required=false)]
            public string MajorClassName { get; set; }

            [NameInMap("SubClasses")]
            [Validation(Required=false)]
            public List<ListAuditContentErrorTypesResponseBodyDataSubClasses> SubClasses { get; set; }
            public class ListAuditContentErrorTypesResponseBodyDataSubClasses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PunctuationError</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

            }

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
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
