// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KGZLxjv9VGkoG9YwHE5wx7k2V6EDybno</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public ListPermissionsRequestOption Option { get; set; }
        public class ListPermissionsRequestOption : TeaModel {
            [NameInMap("FilterRoleIds")]
            [Validation(Required=false)]
            public List<string> FilterRoleIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public ListPermissionsRequestTenantContext TenantContext { get; set; }
        public class ListPermissionsRequestTenantContext : TeaModel {
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
