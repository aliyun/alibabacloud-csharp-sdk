// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RegistryCertConfig : TeaModel {
        /// <summary>
        /// <para>是否跳过TLS证书验证，设置为true时将不验证镜像仓库的证书</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

        /// <summary>
        /// <para>镜像仓库的根CA证书Base64编码，用于自签名证书的验证</para>
        /// 
        /// <b>Example:</b>
        /// <para>cm9vdF9jYV9jZXJ0X2Jhc2U2NA==</para>
        /// </summary>
        [NameInMap("rootCaCertBase64")]
        [Validation(Required=false)]
        public string RootCaCertBase64 { get; set; }

    }

}
