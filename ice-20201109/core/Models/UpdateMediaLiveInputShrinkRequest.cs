// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaLiveInputShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the input.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SEGK5KA6KYKAWQQH</para>
        /// </summary>
        [NameInMap("InputId")]
        [Validation(Required=false)]
        public string InputId { get; set; }

        /// <summary>
        /// <para>The input settings. An input can have up to two sources: primary and backup sources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputSettings")]
        [Validation(Required=false)]
        public string InputSettingsShrink { get; set; }

        /// <summary>
        /// <para>The name of the input. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myinput</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to be associated with the input. This parameter is required for PUSH inputs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;G6G4X5T4SZYPSTT5&quot;]</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public string SecurityGroupIdsShrink { get; set; }

    }

}
