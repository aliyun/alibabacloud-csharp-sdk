// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The description of the orchestration template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <para>Naming rules: The name must be 1 to 63 characters in length and can contain digits, Chinese characters, letters, and hyphens (-). It cannot start with a hyphen (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-account-template</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The tags of the orchestration template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The template content in YAML format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1\nkind: ServiceAccount\nmetadata:\n  name: test-sa</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The templatetype.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <c>kubernetes</c>, the template is displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty or set it to other values, the template is not displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// </list>
        /// <para>Settings this parameter to <c>kubernetes</c> is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes</para>
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
