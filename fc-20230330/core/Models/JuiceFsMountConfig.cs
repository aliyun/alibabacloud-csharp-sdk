// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class JuiceFsMountConfig : TeaModel {
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// <para>The directory mounted to the function.</para>
        /// </summary>
        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>The JuiceFS remote directory.</para>
        /// </summary>
        [NameInMap("remoteDir")]
        [Validation(Required=false)]
        public string RemoteDir { get; set; }

        /// <summary>
        /// <para>The token information.</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The JuiceFS name.</para>
        /// </summary>
        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
