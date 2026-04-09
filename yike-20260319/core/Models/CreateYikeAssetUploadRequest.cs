// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class CreateYikeAssetUploadRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mp4</para>
        /// </summary>
        [NameInMap("FileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>StoryboardInput</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

    }

}
