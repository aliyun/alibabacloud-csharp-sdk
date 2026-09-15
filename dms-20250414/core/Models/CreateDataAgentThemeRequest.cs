// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentThemeRequest : TeaModel {
        /// <summary>
        /// <para>The scenario, which affects the filtering when you view the theme list in the console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>(Recommended) custom: A user-uploaded custom theme with no preset style or information organization structure.</description></item>
        /// <item><description>report: A web report that conforms to the DataAgent information organization structure.</description></item>
        /// <item><description>(Not supported) infographic: An infographic that conforms to the DataAgent information organization structure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The description. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weekly report</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The file source, which affects the backend logic for determining whether the theme is valid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>upload: The file is uploaded through OSS.</description></item>
        /// <item><description>(Not supported) public_url: The file is provided through a public network access OSS URL.</description></item>
        /// <item><description>(Not supported) user_oss: The file is provided through a user OSS URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>upload</para>
        /// </summary>
        [NameInMap("FileFrom")]
        [Validation(Required=false)]
        public string FileFrom { get; set; }

        /// <summary>
        /// <para>The UUID of the theme. The value must be returned by GetDataAgentThemeUploadSignature, and the file must have been uploaded. If the UUID is forged or the file has not been uploaded, the creation fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f8b2c1d************9a3e5f7b1c2d</para>
        /// </summary>
        [NameInMap("ThemeId")]
        [Validation(Required=false)]
        public string ThemeId { get; set; }

        /// <summary>
        /// <para>The display name of the theme. The value can be up to 64 characters in length. This parameter is required when you create a theme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weekly report</para>
        /// </summary>
        [NameInMap("ThemeName")]
        [Validation(Required=false)]
        public string ThemeName { get; set; }

        /// <summary>
        /// <para>The type of the custom theme. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>(Default) template: The theme is a template.</description></item>
        /// <item><description>(Not supported) design: The theme is a DESIGN.md file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("ThemeType")]
        [Validation(Required=false)]
        public string ThemeType { get; set; }

        /// <summary>
        /// <para>The workspace to which the theme belongs. If this parameter is not specified or is set to personal, the personal workspace is used. You can also specify a collaboration workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99fad******qg6c0l4nlacu</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
