// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetOrgOrWebOpenDocContentTaskIdRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20eMKjyp810mMdK4Hz4B5BA6JxAZB1Gv</para>
        /// </summary>
        [NameInMap("DentryUuid")]
        [Validation(Required=false)]
        public string DentryUuid { get; set; }

        [NameInMap("GenerateCp")]
        [Validation(Required=false)]
        public bool? GenerateCp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>markdown</para>
        /// </summary>
        [NameInMap("TargetFormat")]
        [Validation(Required=false)]
        public string TargetFormat { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetOrgOrWebOpenDocContentTaskIdRequestTenantContext TenantContext { get; set; }
        public class GetOrgOrWebOpenDocContentTaskIdRequestTenantContext : TeaModel {
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
