// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ListWordGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code, 00000 indicates success; other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>If an error occurs, returns the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, the maximum number of results returned per page.
        /// Maximum limit: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE2558EC-A9EA-5276-ADB5-107B09CF3D11</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful: true means the call was successful; false means the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>List of keyword group objects.</para>
        /// </summary>
        [NameInMap("WordGroupInfoList")]
        [Validation(Required=false)]
        public List<ListWordGroupResponseBodyWordGroupInfoList> WordGroupInfoList { get; set; }
        public class ListWordGroupResponseBodyWordGroupInfoList : TeaModel {
            /// <summary>
            /// <para>Policy modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673578650000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Keyword group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>Keyword group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>List of associated policy objects.</para>
            /// </summary>
            [NameInMap("PolicyInfoList")]
            [Validation(Required=false)]
            public List<ListWordGroupResponseBodyWordGroupInfoListPolicyInfoList> PolicyInfoList { get; set; }
            public class ListWordGroupResponseBodyWordGroupInfoListPolicyInfoList : TeaModel {
                /// <summary>
                /// <para>Detection policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public long? PolicyId { get; set; }

                /// <summary>
                /// <para>Policy identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mai934jhuekf</para>
                /// </summary>
                [NameInMap("PolicyIdentifier")]
                [Validation(Required=false)]
                public string PolicyIdentifier { get; set; }

                /// <summary>
                /// <para>Detection policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testPoliy</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

        }

    }

}
