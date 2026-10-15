// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AttributeValueInfoDTO : TeaModel {
        /// <summary>
        /// <para>The upper and lower bounds.</para>
        /// </summary>
        [NameInMap("BoundedValue")]
        [Validation(Required=false)]
        public AttributeValueInfoDTOBoundedValue BoundedValue { get; set; }
        public class AttributeValueInfoDTOBoundedValue : TeaModel {
            /// <summary>
            /// <para>The lower bound list.</para>
            /// </summary>
            [NameInMap("LowerBound")]
            [Validation(Required=false)]
            public List<AttributeValueInfoDTO> LowerBound { get; set; }

            /// <summary>
            /// <para>The upper bound list.</para>
            /// </summary>
            [NameInMap("UpperBound")]
            [Validation(Required=false)]
            public List<AttributeValueInfoDTO> UpperBound { get; set; }

        }

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
        /// <para>The description (translated).</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The description property values.</para>
        /// </summary>
        [NameInMap("DescriptionAttributeValues")]
        [Validation(Required=false)]
        public List<AttributeValueInfoDTO> DescriptionAttributeValues { get; set; }

        /// <summary>
        /// <para>The unique identifier.</para>
        /// </summary>
        [NameInMap("IdentifyKey")]
        [Validation(Required=false)]
        public string IdentifyKey { get; set; }

        /// <summary>
        /// <para>The maximum value.</para>
        /// </summary>
        [NameInMap("Max")]
        [Validation(Required=false)]
        public string Max { get; set; }

        /// <summary>
        /// <para>The minimum value.</para>
        /// </summary>
        [NameInMap("Min")]
        [Validation(Required=false)]
        public string Min { get; set; }

        /// <summary>
        /// <para>The operation tags.</para>
        /// </summary>
        [NameInMap("OperationTags")]
        [Validation(Required=false)]
        public List<string> OperationTags { get; set; }

        /// <summary>
        /// <para>The step size.</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public string Step { get; set; }

        /// <summary>
        /// <para>The sub-property values.</para>
        /// </summary>
        [NameInMap("SubAttributeValues")]
        [Validation(Required=false)]
        public Dictionary<string, List<AttributeValueInfoDTO>> SubAttributeValues { get; set; }

        /// <summary>
        /// <para>The enum value.</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The value name (translated).</para>
        /// </summary>
        [NameInMap("ValueName")]
        [Validation(Required=false)]
        public string ValueName { get; set; }

    }

}
