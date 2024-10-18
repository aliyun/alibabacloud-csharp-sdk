// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMultipartFileUploadInfosRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetMultipartFileUploadInfosRequestOption Option { get; set; }
        public class GetMultipartFileUploadInfosRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PreferIntranet")]
            [Validation(Required=false)]
            public bool? PreferIntranet { get; set; }

        }

        [NameInMap("PartNumbers")]
        [Validation(Required=false)]
        public List<int?> PartNumbers { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetMultipartFileUploadInfosRequestTenantContext TenantContext { get; set; }
        public class GetMultipartFileUploadInfosRequestTenantContext : TeaModel {
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
        /// <para>hwHPAAAAAipHxxxxx</para>
        /// </summary>
        [NameInMap("UploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

    }

}
