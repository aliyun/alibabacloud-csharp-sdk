// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RegistryCertConfig : TeaModel {
        /// <summary>
        /// <para>Whether to skip certificate verification.</para>
        /// </summary>
        [NameInMap("insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

        /// <summary>
        /// <para>The certificate authority (CA) certificate of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cm9vdF9jYV9jZXJ0</para>
        /// </summary>
        [NameInMap("rootCaCertBase64")]
        [Validation(Required=false)]
        public string RootCaCertBase64 { get; set; }

    }

}
