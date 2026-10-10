// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AssignUsersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to asynchronously execute user assignment.</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of IDs of the Resource Access Management (RAM) users to be added.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;28036411123456****&quot;,&quot;29234301123456****&quot;]</para>
        /// </summary>
        [NameInMap("RamIdList")]
        [Validation(Required=false)]
        public string RamIdList { get; set; }

        /// <summary>
        /// <para>The role ID. This specifies the role of the agent in the instance after a successful import. Valid roles include administrator, skill group supervisor, and agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent@ccc-test</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The list of skill levels for skill groups. The value is a string in JSON array format. Each array element is an object that contains two fields: skillGroupId and skillLevel. Set skillGroupId to the ID of the skill group to which you want to associate the agent. Set skillLevel to the skill level of the agent in the skill group. Valid values: 1 to 10. A smaller value indicates a stronger business capability, allowing the agent to handle more calls per unit of time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;skillGroupId&quot;:&quot;skillgroup@ccc-test&quot;,&quot;skillLevel&quot;:5}]</para>
        /// </summary>
        [NameInMap("SkillLevelList")]
        [Validation(Required=false)]
        public string SkillLevelList { get; set; }

        /// <summary>
        /// <para>The work mode.</para>
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
