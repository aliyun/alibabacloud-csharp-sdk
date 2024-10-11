// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ModifyUserLevelsOfSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;userId&quot;:&quot;agent1@ccc-test&quot;,&quot;skillLevel&quot;:1},{&quot;userId&quot;:&quot;agent2@ccc-test&quot;,&quot;skillLevel&quot;:10}]</para>
        /// </summary>
        [NameInMap("UserLevelList")]
        [Validation(Required=false)]
        public string UserLevelList { get; set; }

    }

}
