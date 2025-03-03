// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// <para>Architecture</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86_64</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Image version</para>
        /// 
        /// <b>Example:</b>
        /// <para>7.9</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>Platform</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALinux3</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
