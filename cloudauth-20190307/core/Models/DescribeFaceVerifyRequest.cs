// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the ID Verification request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91707dc296d469ad38e4c5efa6a0f24b</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>The image return type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JPG</para>
        /// </summary>
        [NameInMap("PictureReturnType")]
        [Validation(Required=false)]
        public string PictureReturnType { get; set; }

        /// <summary>
        /// <para>The ID of the verification scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000006</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
