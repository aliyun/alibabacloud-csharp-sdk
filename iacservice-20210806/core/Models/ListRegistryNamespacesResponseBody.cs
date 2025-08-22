// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListRegistryNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>53</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("namespaces")]
        [Validation(Required=false)]
        public List<ListRegistryNamespacesResponseBodyNamespaces> Namespaces { get; set; }
        public class ListRegistryNamespacesResponseBodyNamespaces : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-15T02:16:58Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dd</para>
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
            /// <para>shared</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IPTL1Zpr1andEF4lQ3XAYFTgtpI04QQpc5dyKpESXBc=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5FFB0033-A016-5A9D-9283-C123AAA7F71D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
