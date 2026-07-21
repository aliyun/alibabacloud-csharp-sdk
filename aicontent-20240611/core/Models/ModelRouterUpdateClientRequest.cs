// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterUpdateClientRequest : TeaModel {
        /// <summary>
        /// <para>The company address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>A comma-separated list of model IDs that the client can use. If this parameter is left empty, the client can use all models.</para>
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
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("discount")]
        [Validation(Required=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// <para>The client name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的客户</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A remark about the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The client\&quot;s status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
