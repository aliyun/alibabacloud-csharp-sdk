// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ImageConfig : TeaModel {
        [NameInMap("Auth")]
        [Validation(Required=false)]
        public string Auth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DockerRegistry")]
        [Validation(Required=false)]
        public string DockerRegistry { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
