// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class PaidResourceDTO : TeaModel {
        /// <summary>
        /// <para>The time the resource becomes effective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The time the resource expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-10 00:00:00</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>airec-cn-fou41hse8001</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The total quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>The remaining quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("remainQuantity")]
        [Validation(Required=false)]
        public int? RemainQuantity { get; set; }

        /// <summary>
        /// <para>The code of the resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI_ORAL</para>
        /// </summary>
        [NameInMap("resourceCatalogCode")]
        [Validation(Required=false)]
        public string ResourceCatalogCode { get; set; }

        /// <summary>
        /// <para>The name of the resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>口语评测</para>
        /// </summary>
        [NameInMap("resourceCatalogName")]
        [Validation(Required=false)]
        public string ResourceCatalogName { get; set; }

        /// <summary>
        /// <para>The code of the resource package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRE_PAID_RECOURSE_PACKAGE</para>
        /// </summary>
        [NameInMap("resourcePackageCode")]
        [Validation(Required=false)]
        public string ResourcePackageCode { get; set; }

        /// <summary>
        /// <para>The name of the resource package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>智能批改-资源包</para>
        /// </summary>
        [NameInMap("resourcePackageName")]
        [Validation(Required=false)]
        public string ResourcePackageName { get; set; }

        /// <summary>
        /// <para>The status of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("resourceStatus")]
        [Validation(Required=false)]
        public string ResourceStatus { get; set; }

    }

}
