// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFileUploadInfoRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetFileUploadInfoRequestOption Option { get; set; }
        public class GetFileUploadInfoRequestOption : TeaModel {
            [NameInMap("PreCheckParam")]
            [Validation(Required=false)]
            public GetFileUploadInfoRequestOptionPreCheckParam PreCheckParam { get; set; }
            public class GetFileUploadInfoRequestOptionPreCheckParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PreferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZHANGJIAKOU</para>
            /// </summary>
            [NameInMap("PreferRegion")]
            [Validation(Required=false)]
            public string PreferRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DINGTALK</para>
            /// </summary>
            [NameInMap("StorageDriver")]
            [Validation(Required=false)]
            public string StorageDriver { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dentryUuid</para>
        /// </summary>
        [NameInMap("ParentDentryUuid")]
        [Validation(Required=false)]
        public string ParentDentryUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HEADER_SIGNATURE</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetFileUploadInfoRequestTenantContext TenantContext { get; set; }
        public class GetFileUploadInfoRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
