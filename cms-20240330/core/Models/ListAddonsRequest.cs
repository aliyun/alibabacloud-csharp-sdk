// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The language environment. Valid values: zh and en. Default value: zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The add-on catalog version. Valid values: v1 and v2. Default value: v2. If you specify v1, the add-ons in the v1 catalog are listed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The category filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to use regular expression matching for the query field. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("regexp")]
        [Validation(Required=false)]
        public bool? Regexp { get; set; }

        /// <summary>
        /// <para>The search keyword. You can search by add-on name, description, or keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105095</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

    }

}
