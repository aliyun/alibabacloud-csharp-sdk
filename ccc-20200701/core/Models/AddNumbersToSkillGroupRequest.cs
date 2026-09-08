// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AddNumbersToSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>The list of phone number group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;38f5b191-b764-45b8-bd93-4b65f839e13a&quot;]</para>
        /// </summary>
        [NameInMap("InstNumberGroupIdList")]
        [Validation(Required=false)]
        public string InstNumberGroupIdList { get; set; }

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
        /// <para>The list of phone numbers. Ensure that the phone numbers already exist in the current instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;0103182****&quot;,&quot;0102387****&quot;]</para>
        /// </summary>
        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        /// <summary>
        /// <para>The skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

    }

}
