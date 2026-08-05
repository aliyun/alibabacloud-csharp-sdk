// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateAvatarTrainingJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the digital human. The description can be up to 1000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a digital human used for a specific scenario.</para>
        /// </summary>
        [NameInMap("AvatarDescription")]
        [Validation(Required=false)]
        public string AvatarDescription { get; set; }

        /// <summary>
        /// <para>The name of the digital human. The name can be up to 7 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Decimal</para>
        /// </summary>
        [NameInMap("AvatarName")]
        [Validation(Required=false)]
        public string AvatarName { get; set; }

        /// <summary>
        /// <para>The type of the digital human.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DAvatar</para>
        /// </summary>
        [NameInMap("AvatarType")]
        [Validation(Required=false)]
        public string AvatarType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The media asset ID of the avatar image. The ID is 32 characters in length.</description></item>
        /// <item><description>If you subsequently call SubmitAvatarTrainingJob to submit the training, this field is required.</description></item>
        /// <item><description>The image must have equal width and height.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Portrait")]
        [Validation(Required=false)]
        public string Portrait { get; set; }

        /// <summary>
        /// <para>The thumbnail URL.</para>
        /// <list type="bullet">
        /// <item><description>After training succeeds, the thumbnail is uploaded to this address.</description></item>
        /// <item><description>The URL must be a valid public OSS URL under the current user.</description></item>
        /// <item><description>The URL can be up to 512 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png">https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png</a></para>
        /// </summary>
        [NameInMap("Thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// <para>Specifies whether the training video supports a transparent channel.</para>
        /// <remarks>
        /// <para>Notice: Make sure that this setting is consistent with the submitted training video. Otherwise, the synthesized digital human may be abnormal.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Transparent")]
        [Validation(Required=false)]
        public bool? Transparent { get; set; }

        /// <summary>
        /// <para>The media asset ID of the training video.</para>
        /// <list type="bullet">
        /// <item><description>The ID is 32 characters in length.</description></item>
        /// <item><description>Supported formats: mp4, mov, and webm.</description></item>
        /// <item><description>The duration of the material must be between 5 minutes and 15 minutes.</description></item>
        /// <item><description>The resolution of the material must be 1920 × 1080 or 1080 × 1920.</description></item>
        /// <item><description>If you subsequently call SubmitAvatarTrainingJob to submit the training, this field is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
