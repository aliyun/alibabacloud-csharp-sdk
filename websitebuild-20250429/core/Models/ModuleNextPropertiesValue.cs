// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ModuleNextPropertiesValue : TeaModel {
        /// <summary>
        /// <para>Property code, such as &quot;aliyun_commodity_agreement&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>placeholder</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of attribute values</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<ModuleNextPropertiesValueValues> Values { get; set; }
        public class ModuleNextPropertiesValueValues : TeaModel {
            /// <summary>
            /// <para>placeholder</para>
            /// 
            /// <b>Example:</b>
            /// <para>placeholder</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
