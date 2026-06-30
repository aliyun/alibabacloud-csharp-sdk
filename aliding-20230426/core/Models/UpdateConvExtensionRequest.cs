// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateConvExtensionRequest : TeaModel {
        [NameInMap("MobileUrl")]
        [Validation(Required=false)]
        public string MobileUrl { get; set; }

        [NameInMap("PcUrl")]
        [Validation(Required=false)]
        public string PcUrl { get; set; }

        [NameInMap("StaffIdList")]
        [Validation(Required=false)]
        public List<string> StaffIdList { get; set; }

        [NameInMap("SystemUid")]
        [Validation(Required=false)]
        public string SystemUid { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateConvExtensionRequestTenantContext TenantContext { get; set; }
        public class UpdateConvExtensionRequestTenantContext : TeaModel {
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
