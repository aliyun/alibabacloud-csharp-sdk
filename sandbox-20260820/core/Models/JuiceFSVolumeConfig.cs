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

        [NameInMap("baseURL")]
        [Validation(Required=false)]
        public string BaseURL { get; set; }

        [NameInMap("remoteDir")]
        [Validation(Required=false)]
        public string RemoteDir { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
