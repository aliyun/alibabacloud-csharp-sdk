// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TLSConfig : TeaModel {
        /// <summary>
        /// <para>The TLS cipher suites.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        /// <summary>
        /// <para>The maximum TLS version. Valid values: TLSv1.3 and TLSv1.2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.3</para>
        /// </summary>
        [NameInMap("maxVersion")]
        [Validation(Required=false)]
        public string MaxVersion { get; set; }

        /// <summary>
        /// <para>The minimum TLS version. Valid values: TLSv1.3 and TLSv1.2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.0</para>
        /// </summary>
        [NameInMap("minVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
