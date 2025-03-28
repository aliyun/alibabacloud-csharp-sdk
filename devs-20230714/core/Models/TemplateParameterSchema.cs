// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateParameterSchema : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>defaultValue</para>
        /// </summary>
        [NameInMap("default")]
        [Validation(Required=false)]
        public object Default { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameters for testing</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enum")]
        [Validation(Required=false)]
        public List<string> Enum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;^[a-zA-Z._-]+$&quot;</para>
        /// </summary>
        [NameInMap("pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        [NameInMap("roleExtension")]
        [Validation(Required=false)]
        public TemplateParameterSchemaRoleExtension RoleExtension { get; set; }
        public class TemplateParameterSchemaRoleExtension : TeaModel {
            [NameInMap("authorities")]
            [Validation(Required=false)]
            public List<string> Authorities { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
