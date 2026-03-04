// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleVersionsValue : TeaModel {
        /// <summary>
        /// <para>code</para>
        /// 
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>name</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>components</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public Dictionary<string, ModuleVersionsValueComponentsValue> Components { get; set; }

    }

}
