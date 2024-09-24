// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateAvatarTrainingJobRequest : TeaModel {
        [NameInMap("AvatarDescription")]
        [Validation(Required=false)]
        public string AvatarDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AvatarName")]
        [Validation(Required=false)]
        public string AvatarName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2DAvatar</para>
        /// </summary>
        [NameInMap("AvatarType")]
        [Validation(Required=false)]
        public string AvatarType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Portrait")]
        [Validation(Required=false)]
        public string Portrait { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png">https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png</a></para>
        /// </summary>
        [NameInMap("Thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Transparent")]
        [Validation(Required=false)]
        public bool? Transparent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
