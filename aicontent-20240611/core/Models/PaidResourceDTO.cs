// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class PaidResourceDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-09-10 00:00:00</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>airec-cn-fou41hse8001</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("remainQuantity")]
        [Validation(Required=false)]
        public int? RemainQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AI_ORAL</para>
        /// </summary>
        [NameInMap("resourceCatalogCode")]
        [Validation(Required=false)]
        public string ResourceCatalogCode { get; set; }

        [NameInMap("resourceCatalogName")]
        [Validation(Required=false)]
        public string ResourceCatalogName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PRE_PAID_RECOURSE_PACKAGE</para>
        /// </summary>
        [NameInMap("resourcePackageCode")]
        [Validation(Required=false)]
        public string ResourcePackageCode { get; set; }

        [NameInMap("resourcePackageName")]
        [Validation(Required=false)]
        public string ResourcePackageName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("resourceStatus")]
        [Validation(Required=false)]
        public string ResourceStatus { get; set; }

    }

}
