// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByTextResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication details.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public SearchImageByTextResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class SearchImageByTextResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The action for the authentication request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The authentication principal information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encrypted complete diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ImplicitDeny: no policy is matched.</description></item>
            /// <item><description>ExplicitDeny: an explicit Deny policy is matched.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The type of the policy that caused the access denial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PauseNotify</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The description information of all returned products.</para>
        /// </summary>
        [NameInMap("Auctions")]
        [Validation(Required=false)]
        public List<SearchImageByTextResponseBodyAuctions> Auctions { get; set; }
        public class SearchImageByTextResponseBodyAuctions : TeaModel {
            /// <summary>
            /// <para>The image category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8888888</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The custom content defined by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zidingyi</para>
            /// </summary>
            [NameInMap("CustomContent")]
            [Validation(Required=false)]
            public string CustomContent { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr")]
            [Validation(Required=false)]
            public int? IntAttr { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr2")]
            [Validation(Required=false)]
            public int? IntAttr2 { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr3")]
            [Validation(Required=false)]
            public int? IntAttr3 { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr4")]
            [Validation(Required=false)]
            public int? IntAttr4 { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1.jpg</para>
            /// </summary>
            [NameInMap("PicName")]
            [Validation(Required=false)]
            public string PicName { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The image similarity score. Valid values: 0 to 1.</para>
            /// <remarks>
            /// <para>You must upgrade the SDK to V3.1.1 to use this feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("StrAttr")]
            [Validation(Required=false)]
            public string StrAttr { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("StrAttr2")]
            [Validation(Required=false)]
            public string StrAttr2 { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("StrAttr3")]
            [Validation(Required=false)]
            public string StrAttr3 { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("StrAttr4")]
            [Validation(Required=false)]
            public string StrAttr4 { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: successful.</description></item>
        /// <item><description>Non-zero value: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The overview of the search results.</para>
        /// </summary>
        [NameInMap("Head")]
        [Validation(Required=false)]
        public SearchImageByTextResponseBodyHead Head { get; set; }
        public class SearchImageByTextResponseBodyHead : TeaModel {
            /// <summary>
            /// <para>The number of results returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DocsFound")]
            [Validation(Required=false)]
            public int? DocsFound { get; set; }

            /// <summary>
            /// <para>The number of matched results in the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("DocsReturn")]
            [Validation(Required=false)]
            public int? DocsReturn { get; set; }

            /// <summary>
            /// <para>The time consumed by the search, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("SearchTime")]
            [Validation(Required=false)]
            public int? SearchTime { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The category information.</para>
        /// </summary>
        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public SearchImageByTextResponseBodyPicInfo PicInfo { get; set; }
        public class SearchImageByTextResponseBodyPicInfo : TeaModel {
            /// <summary>
            /// <para>All categories supported by the system.</para>
            /// </summary>
            [NameInMap("AllCategories")]
            [Validation(Required=false)]
            public List<SearchImageByTextResponseBodyPicInfoAllCategories> AllCategories { get; set; }
            public class SearchImageByTextResponseBodyPicInfoAllCategories : TeaModel {
                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88888888</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3137727-7D6E-488C-BA21-0E034C38A879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
