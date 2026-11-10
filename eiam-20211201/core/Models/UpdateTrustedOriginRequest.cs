// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateTrustedOriginRequest : TeaModel {
        /// <summary>
        /// <para>The idempotence token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_example</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The trusted origin name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qoder Production Console</para>
        /// </summary>
        [NameInMap("TrustOriginName")]
        [Validation(Required=false)]
        public string TrustOriginName { get; set; }

        /// <summary>
        /// <para>The trusted origin ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>to_example</para>
        /// </summary>
        [NameInMap("TrustedOriginId")]
        [Validation(Required=false)]
        public string TrustedOriginId { get; set; }

        /// <summary>
        /// <para>The trusted origin scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iframe_embed</para>
        /// </summary>
        [NameInMap("TrustedOriginScene")]
        [Validation(Required=false)]
        public List<string> TrustedOriginScene { get; set; }

    }

}
