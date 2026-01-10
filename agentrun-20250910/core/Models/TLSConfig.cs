// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class TLSConfig : TeaModel {
        /// <summary>
        /// <para>TLS 加密套件列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;TLS_RSA_WITH_RC4_128_SHA&quot;]</para>
        /// </summary>
        [NameInMap("cipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        /// <summary>
        /// <para>TLS 最大版本号。</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.3</para>
        /// </summary>
        [NameInMap("maxVersion")]
        [Validation(Required=false)]
        public string MaxVersion { get; set; }

        /// <summary>
        /// <para>TLS 最小版本号。</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.2</para>
        /// </summary>
        [NameInMap("minVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
