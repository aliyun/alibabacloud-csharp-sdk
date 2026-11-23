// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class ModifyExpressConnectRouterInterRegionTransitModeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a unique value from your client for this parameter. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> is different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FF9nMec/RZ6H9oqFn1pvyir/SLRlxCCyHJonbGzqL01hiM6Jb3wJowdHvjCfog7ww1b9rSHMRFJnrUBfVba68TJg==</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sends a check request without modifying the service resource.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect Router (ECR) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecr-mezk2idmsd0vx2****</para>
        /// </summary>
        [NameInMap("EcrId")]
        [Validation(Required=false)]
        public string EcrId { get; set; }

        /// <summary>
        /// <para>The list of inter-region forwarding modes.</para>
        /// </summary>
        [NameInMap("TransitModeList")]
        [Validation(Required=false)]
        public List<ModifyExpressConnectRouterInterRegionTransitModeRequestTransitModeList> TransitModeList { get; set; }
        public class ModifyExpressConnectRouterInterRegionTransitModeRequestTransitModeList : TeaModel {
            /// <summary>
            /// <para>The inter-region forwarding mode of the ECR. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ECMP</b>: The load balancing mode.</para>
            /// </description></item>
            /// <item><description><para><b>NearBy</b>: The nearby forwarding mode.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECMP</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The region where the ECR instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
