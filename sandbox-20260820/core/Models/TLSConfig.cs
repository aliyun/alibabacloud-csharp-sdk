// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class TLSConfig : TeaModel {
        /// <summary>
        /// <para>The list of allowed TLS cipher suites. If this parameter is not specified, the server default cipher suites are used.</para>
        /// </summary>
        [NameInMap("cipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        /// <summary>
        /// <para>The maximum TLS protocol version allowed. Example values: TLSv1.2 and TLSv1.3. If this parameter is not specified, the server default value is used. Do not pass an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.3</para>
        /// </summary>
        [NameInMap("maxVersion")]
        [Validation(Required=false)]
        public string MaxVersion { get; set; }

        /// <summary>
        /// <para>The minimum TLS protocol version allowed. Example values: TLSv1.2 and TLSv1.3. If this parameter is not specified, the server default value is used. Do not pass an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.2</para>
        /// </summary>
        [NameInMap("minVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
