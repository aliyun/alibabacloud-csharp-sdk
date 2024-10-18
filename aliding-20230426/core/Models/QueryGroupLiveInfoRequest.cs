// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryGroupLiveInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Eijxxx</para>
        /// </summary>
        [NameInMap("AnchorUnionId")]
        [Validation(Required=false)]
        public string AnchorUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("LiveUuid")]
        [Validation(Required=false)]
        public string LiveUuid { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryGroupLiveInfoRequestTenantContext TenantContext { get; set; }
        public class QueryGroupLiveInfoRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
