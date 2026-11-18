// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateTrustedOriginRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a value on your client and make sure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters and can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_example</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The browser origin in the format of scheme://host[:port]. It cannot be modified after creation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://console.qoder.com">https://console.qoder.com</a></para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The name of the trusted origin used for management, display, and auditing. If you do not specify this parameter, it is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qoder Production Console</para>
        /// </summary>
        [NameInMap("TrustOriginName")]
        [Validation(Required=false)]
        public string TrustOriginName { get; set; }

        /// <summary>
        /// <para>The trusted origin scenarios. Only iframe_embed and cors are supported. Specify at least one value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;iframe_embed&quot;]</para>
        /// </summary>
        [NameInMap("TrustedOriginScene")]
        [Validation(Required=false)]
        public List<string> TrustedOriginScene { get; set; }

    }

}
