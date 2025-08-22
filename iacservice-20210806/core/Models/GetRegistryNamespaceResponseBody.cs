// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRegistryNamespaceResponseBody : TeaModel {
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public GetRegistryNamespaceResponseBodyNamespace Namespace { get; set; }
        public class GetRegistryNamespaceResponseBodyNamespace : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-20T02:18:29Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("maintainer")]
            [Validation(Required=false)]
            public string Maintainer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("modules")]
            [Validation(Required=false)]
            public int? Modules { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_namespace</para>
            /// </summary>
            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            [NameInMap("sharedAccounts")]
            [Validation(Required=false)]
            public List<long?> SharedAccounts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>share</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26684763-5BAB-58C8-BA4F-9D622AB7AD14</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
