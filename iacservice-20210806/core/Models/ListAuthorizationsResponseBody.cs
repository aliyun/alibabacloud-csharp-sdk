// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListAuthorizationsResponseBody : TeaModel {
        [NameInMap("authorizations")]
        [Validation(Required=false)]
        public List<ListAuthorizationsResponseBodyAuthorizations> Authorizations { get; set; }
        public class ListAuthorizationsResponseBodyAuthorizations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>auth-433aead756057ffee37b763564fdd</para>
            /// </summary>
            [NameInMap("authorizationId")]
            [Validation(Required=false)]
            public string AuthorizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-16T03:41:34Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dueTime")]
            [Validation(Required=false)]
            public string DueTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-395f8626622affff71ccbf5b25885</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aadfaf</para>
            /// </summary>
            [NameInMap("ownerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>asdf123</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C67A913A-2A0F-53F6-A041-56CC4CA1E593</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
