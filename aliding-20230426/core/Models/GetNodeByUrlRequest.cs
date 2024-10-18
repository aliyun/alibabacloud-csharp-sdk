// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetNodeByUrlRequest : TeaModel {
        [NameInMap("Option")]
        [Validation(Required=false)]
        public GetNodeByUrlRequestOption Option { get; set; }
        public class GetNodeByUrlRequestOption : TeaModel {
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
        public GetNodeByUrlRequestTenantContext TenantContext { get; set; }
        public class GetNodeByUrlRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alidocs.dingtalk.com/i/nodes/EpGBa2L*********gN7R35y">https://alidocs.dingtalk.com/i/nodes/EpGBa2L*********gN7R35y</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
