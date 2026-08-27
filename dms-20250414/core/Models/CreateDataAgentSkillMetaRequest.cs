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
        /// <item><description>By default, this parameter is optional. The backend parses the ZIP package specified by UploadLocation to obtain the skill description.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>This is a demo skill description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The skill name.</para>
        /// <list type="bullet">
        /// <item><description>By default, this parameter is optional. The backend parses the ZIP package specified by UploadLocation to obtain the skill name.</description></item>
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
        /// <item><description>Format: The UploadDir field returned by the DescribeSkillFileUploadSignature operation concatenated with the file name.</description></item>
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
