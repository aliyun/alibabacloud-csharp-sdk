// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentRequest : TeaModel {
        /// <summary>
        /// <para>省略时读取当前定义；指定已发布版本时读取对应快照及固定的官方 Skill、套件制品版本；指定当前未发布版本时仍返回草稿，不返回固定制品版本。不是 POP 系统参数 Version。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public int? AgentVersion { get; set; }

        /// <summary>
        /// <para>The name of the skill to retrieve.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-skill</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
