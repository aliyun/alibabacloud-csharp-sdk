// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMultiDimTableAllSheetsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>144972</para>
        /// </summary>
        [NameInMap("BaseId")]
        [Validation(Required=false)]
        public string BaseId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetMultiDimTableAllSheetsRequestTenantContext TenantContext { get; set; }
        public class GetMultiDimTableAllSheetsRequestTenantContext : TeaModel {
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
