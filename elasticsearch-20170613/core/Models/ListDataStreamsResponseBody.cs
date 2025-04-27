// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDataStreamsResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDataStreamsResponseBodyHeaders Headers { get; set; }
        public class ListDataStreamsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("X-Managed-Count")]
            [Validation(Required=false)]
            public int? XManagedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>143993923932990</para>
            /// </summary>
            [NameInMap("X-Managed-StorageSize")]
            [Validation(Required=false)]
            public long? XManagedStorageSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDataStreamsResponseBodyResult> Result { get; set; }
        public class ListDataStreamsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Green</para>
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rollver1</para>
            /// </summary>
            [NameInMap("ilmPolicyName")]
            [Validation(Required=false)]
            public string IlmPolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>template1</para>
            /// </summary>
            [NameInMap("indexTemplateName")]
            [Validation(Required=false)]
            public string IndexTemplateName { get; set; }

            [NameInMap("indices")]
            [Validation(Required=false)]
            public List<ListDataStreamsResponseBodyResultIndices> Indices { get; set; }
            public class ListDataStreamsResponseBodyResultIndices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-07-13T03:58:07.253Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Green</para>
                /// </summary>
                [NameInMap("health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>following</para>
                /// </summary>
                [NameInMap("managedStatus")]
                [Validation(Required=false)]
                public string ManagedStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Log1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15393899</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788239393298</para>
            /// </summary>
            [NameInMap("managedStorageSize")]
            [Validation(Required=false)]
            public long? ManagedStorageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-index-0001</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1788239393298</para>
            /// </summary>
            [NameInMap("totalStorageSize")]
            [Validation(Required=false)]
            public long? TotalStorageSize { get; set; }

        }

    }

}
