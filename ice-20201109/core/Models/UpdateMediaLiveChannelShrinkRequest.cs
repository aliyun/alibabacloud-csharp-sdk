// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaLiveChannelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The audio settings.</para>
        /// </summary>
        [NameInMap("AudioSettings")]
        [Validation(Required=false)]
        public string AudioSettingsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SEGK5KA6KYKAWQQH</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The inputs associated with the channel.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputAttachments")]
        [Validation(Required=false)]
        public string InputAttachmentsShrink { get; set; }

        /// <summary>
        /// <para>The name of the channel. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mych</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputGroups")]
        [Validation(Required=false)]
        public string OutputGroupsShrink { get; set; }

        /// <summary>
        /// <para>The video settings.</para>
        /// </summary>
        [NameInMap("VideoSettings")]
        [Validation(Required=false)]
        public string VideoSettingsShrink { get; set; }

    }

}
