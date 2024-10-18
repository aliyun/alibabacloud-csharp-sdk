// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryOrgHonorsRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryOrgHonorsRequestTenantContext TenantContext { get; set; }
        public class QueryOrgHonorsRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>487986704507650</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

    }

}
