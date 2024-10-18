// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>next_token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MNDoBb60VLBPraakI1Ywxyyn8lemrZQ3</para>
        /// </summary>
        [NameInMap("ParentNodeId")]
        [Validation(Required=false)]
        public string ParentNodeId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public ListNodesRequestTenantContext TenantContext { get; set; }
        public class ListNodesRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithPermissionRole")]
        [Validation(Required=false)]
        public bool? WithPermissionRole { get; set; }

    }

}
