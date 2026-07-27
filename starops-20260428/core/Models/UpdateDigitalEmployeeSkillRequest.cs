// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class UpdateDigitalEmployeeSkillRequest : TeaModel {
        /// <summary>
        /// <para>The description of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the skill is enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>An array of skill files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<UpdateDigitalEmployeeSkillRequestFiles> Files { get; set; }
        public class UpdateDigitalEmployeeSkillRequestFiles : TeaModel {
            /// <summary>
            /// <para>The content of the skill file.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// <h2>name: skill
            /// description: description</h2>
            /// <h1>skill</h1>
            /// <para>skill test</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The name of the skill file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL.md</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Notes or comments about the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
