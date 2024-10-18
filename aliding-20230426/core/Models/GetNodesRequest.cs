// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNodesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetNodesRequestOption Option { get; set; }
        public class GetNodesRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WithPermissionRole")]
            [Validation(Required=false)]
            public bool? WithPermissionRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WithStatisticalInfo")]
            [Validation(Required=false)]
            public bool? WithStatisticalInfo { get; set; }

        }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetNodesRequestTenantContext TenantContext { get; set; }
        public class GetNodesRequestTenantContext : TeaModel {
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
