// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class JuiceFSVolumeConfig : TeaModel {
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://127.0.0.1:8080">http://127.0.0.1:8080</a></para>
        /// </summary>
        [NameInMap("baseURL")]
        [Validation(Required=false)]
        public string BaseURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/sandbox/workspace</para>
        /// </summary>
        [NameInMap("remoteDir")]
        [Validation(Required=false)]
        public string RemoteDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>data</para>
        /// </summary>
        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
