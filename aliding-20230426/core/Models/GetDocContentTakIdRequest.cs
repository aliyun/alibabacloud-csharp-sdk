// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetDocContentTakIdRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qnYMoO1rWxrkmoj2I5L2PYkoJ47Z3je9</para>
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
        public GetDocContentTakIdRequestTenantContext TenantContext { get; set; }
        public class GetDocContentTakIdRequestTenantContext : TeaModel {
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
