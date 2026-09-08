// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class SignInGroupRequest : TeaModel {
        /// <summary>
        /// <para>If an agent has already signed in to some skill groups, setting this parameter to true allows the agent to sign in to additional skill groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Additivity")]
        [Validation(Required=false)]
        public bool? Additivity { get; set; }

        /// <summary>
        /// <para>Chat device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c51c9116c36537cb850dc1081d745df</para>
        /// </summary>
        [NameInMap("ChatDeviceId")]
        [Validation(Required=false)]
        public string ChatDeviceId { get; set; }

        /// <summary>
        /// <para>Voice device ID. When multiple voice devices are active, use this parameter to specify one of them, such as a browser Web Real-Time Communication (WebRTC) endpoint or a SIP phone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CCC-xx.xx.xx.xx-chrome119-bse1b618bff3xxxxd</para>
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
        /// <para>List of skill group IDs to sign in to, formatted as a JSON array string, where each array element is a skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;skillgroup1@ccc-test&quot;,&quot;skillgroup2@ccc-test&quot;]</para>
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

    }

}
