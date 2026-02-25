// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebTLSConfig : TeaModel {
        /// <summary>
        /// <para>The supported cipher suites.</para>
        /// </summary>
        [NameInMap("CipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        /// <summary>
        /// <para>The supported maximum TLS protocol version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.3</para>
        /// </summary>
        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public string MaxVersion { get; set; }

        /// <summary>
        /// <para>The supported minimum TLS protocol version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.0</para>
        /// </summary>
        [NameInMap("MinVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
