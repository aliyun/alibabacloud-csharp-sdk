// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateApplicationTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of custom actions to be added or updated for built-in applications. This list is merged with RemoveBuiltInApplicationCustomActions by removing items first and then adding items. The same application ID cannot appear in both lists at the same time.</para>
        /// </summary>
        [NameInMap("AddBuiltInApplicationCustomActions")]
        [Validation(Required=false)]
        public string AddBuiltInApplicationCustomActionsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the application template to be modified. The template must exist within the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ati-4f0691c56b8d4f06</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the application template. The name must be 1 to 64 characters in length and can contain Chinese characters, letters, digits, hyphens (-), underscores (_), and periods (.). It cannot contain spaces. If this parameter is not specified or is left empty, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application template 02</para>
        /// </summary>
        [NameInMap("ApplicationTemplateName")]
        [Validation(Required=false)]
        public string ApplicationTemplateName { get; set; }

        /// <summary>
        /// <para>The switch status of built-in application control. Only <b>Enable</b> is supported. If you specify Disable, an error is returned. If this parameter is not specified or is left empty, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BuiltInApplicationStatus")]
        [Validation(Required=false)]
        public string BuiltInApplicationStatus { get; set; }

        /// <summary>
        /// <para>The switch status of custom rules for applications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.
        /// If this parameter is not specified or is left empty, the original value is retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("CustomRuleStatus")]
        [Validation(Required=false)]
        public string CustomRuleStatus { get; set; }

        /// <summary>
        /// <para>The description of the application template. The description can be up to 128 characters in length. If this parameter is not specified, the original value is retained. If an empty string is specified, the description is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office network application control</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of built-in applications for which you want to remove custom actions. After removal, these applications revert to the default actions of the template. The same application ID cannot appear in AddBuiltInApplicationCustomActions at the same time.</para>
        /// </summary>
        [NameInMap("RemoveBuiltInApplicationCustomActions")]
        [Validation(Required=false)]
        public string RemoveBuiltInApplicationCustomActionsShrink { get; set; }

        /// <summary>
        /// <para>The overall switch status of the application template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.
        /// If this parameter is not specified or is left empty, the original value is retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// <para>The action for unidentified applications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Allow</b>: Allow.</description></item>
        /// <item><description><b>Alert</b>: Monitor.</description></item>
        /// <item><description><b>Deny</b>: Block.
        /// If this parameter is not specified or is left empty, the original value is retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Alert</para>
        /// </summary>
        [NameInMap("UnknownAction")]
        [Validation(Required=false)]
        public string UnknownAction { get; set; }

    }

}
