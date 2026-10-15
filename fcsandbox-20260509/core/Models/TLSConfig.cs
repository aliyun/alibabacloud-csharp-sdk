// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class TLSConfig : TeaModel {
        /// <summary>
        /// <para>The list of allowed TLS cipher suites.</para>
        /// </summary>
        [NameInMap("cipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        /// <summary>
        /// <para>The maximum allowed TLS version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.3</para>
        /// </summary>
        [NameInMap("maxVersion")]
        [Validation(Required=false)]
        public string MaxVersion { get; set; }

        /// <summary>
        /// <para>The minimum allowed TLS version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.2</para>
        /// </summary>
        [NameInMap("minVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
