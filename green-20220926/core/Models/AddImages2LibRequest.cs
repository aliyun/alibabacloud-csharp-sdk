// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddImages2LibRequest : TeaModel {
        /// <summary>
        /// <para>URL of the image to be uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload/ea7a98f9-f8bd-4905-a79b-963c9da419c5.jpg</para>
        /// </summary>
        [NameInMap("ImgUrl")]
        [Validation(Required=false)]
        public string ImgUrl { get; set; }

        /// <summary>
        /// <para>The ID of image library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>Region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
