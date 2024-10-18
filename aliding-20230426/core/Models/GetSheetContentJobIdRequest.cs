// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSheetContentJobIdRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>MNDoBb60VLYDGNPytQe7Gzp4JlemrZQ3</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingTalksheetToxlsx</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetSheetContentJobIdRequestTenantContext TenantContext { get; set; }
        public class GetSheetContentJobIdRequestTenantContext : TeaModel {
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
