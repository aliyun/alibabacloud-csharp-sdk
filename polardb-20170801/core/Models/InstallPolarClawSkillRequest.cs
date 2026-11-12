// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class InstallPolarClawSkillRequest : TeaModel {
        /// <summary>
        /// <para>The target agent in the workspace. If this parameter is not specified, the default agent is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

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
        /// <para>Specifies whether to force reinstallation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The scope. Valid values: workspace (default) and global (shared directory). This parameter is mutually exclusive with AgentId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.0</para>
        /// </summary>
        [NameInMap("SkillVersion")]
        [Validation(Required=false)]
        public string SkillVersion { get; set; }

        /// <summary>
        /// <para>The skill identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibacloud-rds-copilot</para>
        /// </summary>
        [NameInMap("Slug")]
        [Validation(Required=false)]
        public string Slug { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clawhub</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The URL for installing the skill. This parameter is not supported. If a value is provided, a 400 InvalidParameters error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/skill.tar.gz">https://example.com/skill.tar.gz</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
