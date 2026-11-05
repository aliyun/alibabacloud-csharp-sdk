// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentSkillMetaRequest : TeaModel {
        /// <summary>
        /// <para>The skill description.</para>
        /// <list type="bullet">
        /// <item><description>Optional by default. The backend parses the ZIP package specified by UploadLocation to obtain the skill description.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>This is a demo skill description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The skill ID. If you specify this parameter, the uploaded skill overwrites the existing skill, and the original skill content is replaced.</para>
        /// <list type="bullet">
        /// <item><description>Note: The original skill name and the newly uploaded skill name must match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ski-04pomiln*************j0</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The skill name.</para>
        /// <list type="bullet">
        /// <item><description>Optional by default. The backend parses the ZIP package specified by UploadLocation to obtain the skill name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>data-query-skill</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The full path for uploading the skill ZIP file.</para>
        /// <list type="bullet">
        /// <item><description>Format: Concatenate the UploadDir field returned by the DescribeSkillFileUploadSignature operation with the file name.</description></item>
        /// <item><description>Example: ${UploadDir}/${Filename}</description></item>
        /// </list>
        /// </summary>
        [NameInMap("UploadLocation")]
        [Validation(Required=false)]
        public string UploadLocation { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmbbtfv8***********zuqko6</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
