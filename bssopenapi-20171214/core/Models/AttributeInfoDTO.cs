// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AttributeInfoDTO : TeaModel {
        /// <summary>
        /// <para>The property categories.</para>
        /// </summary>
        [NameInMap("AttributeCategories")]
        [Validation(Required=false)]
        public List<string> AttributeCategories { get; set; }

        /// <summary>
        /// <para>The property source.</para>
        /// </summary>
        [NameInMap("AttributeSource")]
        [Validation(Required=false)]
        public string AttributeSource { get; set; }

        /// <summary>
        /// <para>The property type.</para>
        /// </summary>
        [NameInMap("AttributeType")]
        [Validation(Required=false)]
        public string AttributeType { get; set; }

        /// <summary>
        /// <para>The property code.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The composite properties (basic information).</para>
        /// </summary>
        [NameInMap("CompositeAttributes")]
        [Validation(Required=false)]
        public List<BaseAttributeInfoDTO> CompositeAttributes { get; set; }

        /// <summary>
        /// <para>The property description (translated).</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The description properties (basic information).</para>
        /// </summary>
        [NameInMap("DescriptionAttributes")]
        [Validation(Required=false)]
        public List<BaseAttributeInfoDTO> DescriptionAttributes { get; set; }

        /// <summary>
        /// <para>The property name (translated).</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The O&amp;M property configuration.</para>
        /// </summary>
        [NameInMap("OperationalAttributeConfig")]
        [Validation(Required=false)]
        public string OperationalAttributeConfig { get; set; }

        /// <summary>
        /// <para>The O&amp;M property type.</para>
        /// </summary>
        [NameInMap("OperationalAttributeType")]
        [Validation(Required=false)]
        public string OperationalAttributeType { get; set; }

        /// <summary>
        /// <para>The sub-properties (complete information).</para>
        /// </summary>
        [NameInMap("SubAttributes")]
        [Validation(Required=false)]
        public List<AttributeInfoDTO> SubAttributes { get; set; }

        /// <summary>
        /// <para>The unit.</para>
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// <para>The value type.</para>
        /// </summary>
        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

        /// <summary>
        /// <para>The property value list.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<AttributeValueInfoDTO> Values { get; set; }

    }

}
