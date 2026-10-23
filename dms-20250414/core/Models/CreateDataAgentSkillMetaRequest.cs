// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentSkillMetaRequest : TeaModel {
        /// <summary>
        /// <para>The skill description. This parameter is optional. If not specified, the backend parses the ZIP package specified by UploadLocation to obtain the skill description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a demo skill description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The skill ID. If you specify this parameter, the uploaded skill overwrites the existing skill and replaces the original skill content. Note: The name of the original skill and the newly uploaded skill must be identical.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ski-04pomiln*************j0</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The skill name. This parameter is optional. If not specified, the backend parses the ZIP package specified by UploadLocation to obtain the skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data-query-skill</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The full path for the skill ZIP file upload.</para>
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
