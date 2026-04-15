// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetScencegroupFileDownloadurlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc*****xyz</para>
        /// </summary>
        [NameInMap("DownloadCode")]
        [Validation(Required=false)]
        public string DownloadCode { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetScencegroupFileDownloadurlRequestTenantContext TenantContext { get; set; }
        public class GetScencegroupFileDownloadurlRequestTenantContext : TeaModel {
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
