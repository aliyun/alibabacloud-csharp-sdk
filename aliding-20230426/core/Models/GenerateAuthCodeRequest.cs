// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GenerateAuthCodeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-qwenwork</para>
        /// </summary>
        [NameInMap("BucAppName")]
        [Validation(Required=false)]
        public string BucAppName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder-sso-ticket</para>
        /// </summary>
        [NameInMap("SsoTicket")]
        [Validation(Required=false)]
        public string SsoTicket { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GenerateAuthCodeRequestTenantContext TenantContext { get; set; }
        public class GenerateAuthCodeRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/oauth/callback">https://example.com/oauth/callback</a></para>
        /// </summary>
        [NameInMap("ValidRedirectUri")]
        [Validation(Required=false)]
        public string ValidRedirectUri { get; set; }

    }

}
