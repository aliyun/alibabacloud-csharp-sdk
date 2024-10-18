// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CommitFileRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public CommitFileRequestOption Option { get; set; }
        public class CommitFileRequestOption : TeaModel {
            [NameInMap("AppProperties")]
            [Validation(Required=false)]
            public List<CommitFileRequestOptionAppProperties> AppProperties { get; set; }
            public class CommitFileRequestOptionAppProperties : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>property_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>property_value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AUTO_RENAME</para>
            /// </summary>
            [NameInMap("ConflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConvertToOnlineDoc")]
            [Validation(Required=false)]
            public bool? ConvertToOnlineDoc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DOC</para>
            /// </summary>
            [NameInMap("ConvertToOnlineDocTargetDocumentType")]
            [Validation(Required=false)]
            public string ConvertToOnlineDocTargetDocumentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dentryUuid</para>
        /// </summary>
        [NameInMap("ParentDentryUuid")]
        [Validation(Required=false)]
        public string ParentDentryUuid { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CommitFileRequestTenantContext TenantContext { get; set; }
        public class CommitFileRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>upload_key</para>
        /// </summary>
        [NameInMap("UploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

    }

}
