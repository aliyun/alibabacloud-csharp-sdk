// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateAvatarTrainingJobRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The description of the digital human.</description></item>
        /// <item><description>The description can be up to 1,000 characters in length.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AvatarDescription")]
        [Validation(Required=false)]
        public string AvatarDescription { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The name of the digital human.</description></item>
        /// <item><description>The name can be up to seven characters in length.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AvatarName")]
        [Validation(Required=false)]
        public string AvatarName { get; set; }

        /// <summary>
        /// <para>The ID of the digital human training job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>cdb3e74639973036bc84</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The media asset ID of the portrait image.</description></item>
        /// <item><description>The value must be 32 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
        /// </summary>
        [NameInMap("Portrait")]
        [Validation(Required=false)]
        public string Portrait { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The thumbnail URL.</description></item>
        /// <item><description>After the digital human is trained, the thumbnail is uploaded to this URL.</description></item>
        /// <item><description>The URL must be a valid public Object Storage Service (OSS) URL.</description></item>
        /// <item><description>The URL can be up to 512 characters in length.</description></item>
        /// <item><description>The URL cannot be updated after the digital human is trained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png">https://your-bucket.oss-cn-hangzhou.aliyuncs.com/thumbnail.png</a></para>
        /// </summary>
        [NameInMap("Thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Indicates whether the input video supports alpha channels.</para>
        /// </description></item>
        /// <item><description><para>You can modify this parameter only if the job is in the Init or Fail state.</para>
        /// <para>**</para>
        /// <para><b>Note</b>: Make sure that the current settings are consistent with those of the submitted training video. Otherwise, the digital human may malfunction.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Transparent")]
        [Validation(Required=false)]
        public bool? Transparent { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The ID of the video used for training.</description></item>
        /// <item><description>The value must be 32 characters in length.</description></item>
        /// <item><description>Supported formats: MP4, MOV, and WebM.</description></item>
        /// <item><description>The duration of the video must be 5 to 15 minutes.</description></item>
        /// <item><description>The resolution of the video must be 1920×1080 or 1080×1920.</description></item>
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
