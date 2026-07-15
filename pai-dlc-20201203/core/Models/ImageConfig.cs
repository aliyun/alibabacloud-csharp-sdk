// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ImageConfig : TeaModel {
        /// <summary>
        /// <para>Image repository authentication information</para>
        /// </summary>
        [NameInMap("Auth")]
        [Validation(Required=false)]
        public string Auth { get; set; }

        /// <summary>
        /// <para>Image repository address</para>
        /// 
        /// <b>Example:</b>
        /// <para>docker****registry.com</para>
        /// </summary>
        [NameInMap("DockerRegistry")]
        [Validation(Required=false)]
        public string DockerRegistry { get; set; }

        /// <summary>
        /// <para>Image repository password</para>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Image repository username</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
