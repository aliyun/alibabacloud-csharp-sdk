// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdatePolarClawSkillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Skill API key. An empty string indicates that the key is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-api</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The environment variables as a key-value map. A null value indicates that the variable is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NETA_TOKEN&quot;:&quot;my-token&quot;}</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string EnvShrink { get; set; }

        /// <summary>
        /// <para>The Skill identifier key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibacloud-rds-copilot</para>
        /// </summary>
        [NameInMap("SkillKey")]
        [Validation(Required=false)]
        public string SkillKey { get; set; }

    }

}
