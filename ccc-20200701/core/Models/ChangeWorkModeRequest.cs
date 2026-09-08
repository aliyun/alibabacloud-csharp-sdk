// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ChangeWorkModeRequest : TeaModel {
        /// <summary>
        /// <para>Device ID, which is the identity ID of a browser-based Web Real-Time Communication (WebRTC) softphone or a physical phone device. Only one type of device can be registered at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACC-YUNBS-1.0.10-****</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The agent\&quot;s personal phone number, which is used in off-site mode. The agent can use this number to answer calls in off-site mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1382114****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>List of skill groups to sign in to. When changing the work mode to off-site mode, you can use this parameter to specify the list of skill groups that the off-site agent needs to sign in to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;online-1@ccc-test&quot;,&quot;online-2@ccc-test&quot;,&quot;online-3@ccc-test&quot;,&quot;skg-default@ccc-test&quot;]</para>
        /// </summary>
        [NameInMap("SignedSkillGroupIdList")]
        [Validation(Required=false)]
        public string SignedSkillGroupIdList { get; set; }

        /// <summary>
        /// <para>Agent ID. If not specified, the agent mapped to the current Resource Access Management (RAM) user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Work mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON_SITE</para>
        /// </summary>
        [NameInMap("WorkMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

    }

}
