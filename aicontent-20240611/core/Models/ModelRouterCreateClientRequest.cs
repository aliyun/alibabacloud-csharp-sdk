// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateClientRequest : TeaModel {
        /// <summary>
        /// <para>The company address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The allowed model group configuration in JSON string format: {&quot;model_ids&quot;:[101],&quot;group_ids&quot;:[&quot;mg_xxx&quot;]}. If both this field and allowedModels are specified, this field takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model_ids&quot;:[101],&quot;group_ids&quot;:[&quot;mg_xxx&quot;]}</para>
        /// </summary>
        [NameInMap("allowedModelGroupConfig")]
        [Validation(Required=false)]
        public string AllowedModelGroupConfig { get; set; }

        /// <summary>
        /// <para>The list of allowed model IDs, separated by commas. An empty value indicates all models are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("allowedModels")]
        [Validation(Required=false)]
        public string AllowedModels { get; set; }

        /// <summary>
        /// <para>The contact information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        /// <summary>
        /// <para>The discount coefficient. A value of 1.0 indicates no discount, and 0.8 indicates a 20% discount. Default value: 1.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("discount")]
        [Validation(Required=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// <para>The customer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCustomer</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the parent department. If not specified, a top-level department is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>292090</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remarks</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
