// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebNASMountPoint : TeaModel {
        /// <summary>
        /// <para>The local mount directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/consumer/log</para>
        /// </summary>
        [NameInMap("MountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        /// <summary>
        /// <para>The mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("NasAddr")]
        [Validation(Required=false)]
        public string NasAddr { get; set; }

        /// <summary>
        /// <para>The mount directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("NasPath")]
        [Validation(Required=false)]
        public string NasPath { get; set; }

    }

}
