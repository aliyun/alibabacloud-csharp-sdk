// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyWuyingServerSpecRequest : TeaModel {
        /// <summary>
        /// <para>The status of the workstation after the specification change is complete.</para>
        /// <list type="bullet">
        /// <item><description><c>stopped</c>: Shuts down the workstation after the specification change is complete.</description></item>
        /// </list>
        /// <para>This option is applicable to Enterprise Edition or container workstations that support this setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stopped</para>
        /// </summary>
        [NameInMap("AfterStatus")]
        [Validation(Required=false)]
        public string AfterStatus { get; set; }

        /// <summary>
        /// <para>The product type of the target workstation, which must be consistent with the actual type of the resource. For Enterprise Edition workstations, use <c>WuyingServer</c>. If this parameter is omitted, <c>WuyingServer</c> is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WuyingServer</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the promotion, which is used to identify a promotional event or coupon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The ID of the target workstation specification. This parameter is required when you call the operation. Select a specification that is available in the region where the workstation is located and compatible with existing resources.</para>
        /// <para><b>Limits:</b> Conversion between CPU specifications and GPU specifications is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.proworkstation_flagship_elite_ne.96c384g.192g4x</para>
        /// </summary>
        [NameInMap("ServerInstanceType")]
        [Validation(Required=false)]
        public string ServerInstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the workstation whose specifications you want to modify. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-0bw2f11****dial</para>
        /// </summary>
        [NameInMap("WuyingServerId")]
        [Validation(Required=false)]
        public string WuyingServerId { get; set; }

    }

}
