// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpgradeMeshEditionPartiallyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to upgrade the ASM gateways for the ASM instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ASMGatewayContinue")]
        [Validation(Required=false)]
        public bool? ASMGatewayContinue { get; set; }

        /// <summary>
        /// <para>The expected version that desired to be upgraded to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.15.3.118-g4712daf0-aliyun</para>
        /// </summary>
        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public string ExpectedVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform an upgrade check. If the value of this parameter is set to true, only the upgrade check is performed and the ASM instance is not upgraded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PreCheck")]
        [Validation(Required=false)]
        public bool? PreCheck { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca04bc38979214bf2882be79d39b4****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to upgrade the ASM instance to Professional Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SwitchToPro")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SwitchToPro { get; set; }

        /// <summary>
        /// <para>Specifies the ASM gateways to be upgraded. Separate multiple ASM gateways with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingressgateway1,ingressgateway2</para>
        /// </summary>
        [NameInMap("UpgradeGatewayRecords")]
        [Validation(Required=false)]
        public string UpgradeGatewayRecords { get; set; }

    }

}
