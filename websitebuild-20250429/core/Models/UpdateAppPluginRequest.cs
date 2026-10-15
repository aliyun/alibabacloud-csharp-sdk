// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UpdateAppPluginRequest : TeaModel {
        /// <summary>
        /// <para>The category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataManagement</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The configuration form in React JSON Schema format.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ConfigItems")]
        [Validation(Required=false)]
        public string ConfigItems { get; set; }

        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Other extension information in JSON format for future parameter expansion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The hook definitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string Hooks { get; set; }

        /// <summary>
        /// <para>The plug-in description.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01ANcLnQ1bCX7tZPVMJ_!!6000000003429-2-tps-100-100.png">https://img.alicdn.com/imgextra/i4/O1CN01ANcLnQ1bCX7tZPVMJ_!!6000000003429-2-tps-100-100.png</a></para>
        /// </summary>
        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>The gateway plug-in ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1bae9ceaceea432d91c7069fab0dfc02</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The plug-in name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alisecguard</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// <para>The plug-in version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("PluginVersion")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// <para>The skill header information for model selection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("SkillHeader")]
        [Validation(Required=false)]
        public string SkillHeader { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The visibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
