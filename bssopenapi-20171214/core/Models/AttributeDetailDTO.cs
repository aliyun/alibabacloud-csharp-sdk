// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AttributeDetailDTO : TeaModel {
        /// <summary>
        /// <para>The property code.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The default value.</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>The property status.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of valid values for the property.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<AttributeDetailDTOValues> Values { get; set; }
        public class AttributeDetailDTOValues : TeaModel {
            /// <summary>
            /// <para>The list of cascading property values (recursive structure).</para>
            /// </summary>
            [NameInMap("CascadingAttributeValues")]
            [Validation(Required=false)]
            public List<AttributeDetailDTO> CascadingAttributeValues { get; set; }

            /// <summary>
            /// <para>The property value, which corresponds to the identifyKey in the property value definition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
