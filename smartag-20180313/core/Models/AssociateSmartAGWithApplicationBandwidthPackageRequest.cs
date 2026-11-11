// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AssociateSmartAGWithApplicationBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the bandwidth plan for application acceleration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abwp-7963l7iqnquyj3****</para>
        /// </summary>
        [NameInMap("ApplicationBandwidthPackageId")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The list of Smart Access Gateway instances to be associated.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AssociateConfigs")]
        [Validation(Required=false)]
        public List<AssociateSmartAGWithApplicationBandwidthPackageRequestAssociateConfigs> AssociateConfigs { get; set; }
        public class AssociateSmartAGWithApplicationBandwidthPackageRequestAssociateConfigs : TeaModel {
            /// <summary>
            /// <para>The peak bandwidth for application acceleration of the Smart Access Gateway instance. Unit: Mbit/s.</para>
            /// <remarks>
            /// <para>The peak bandwidth for application acceleration of each Smart Access Gateway instance cannot exceed the peak bandwidth of the associated bandwidth plan for application acceleration.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The Smart Access Gateway instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-gf5serujbhrn2j****</para>
            /// </summary>
            [NameInMap("SmartAGId")]
            [Validation(Required=false)]
            public string SmartAGId { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the association request. The dry run includes permission and instance status checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Sends a normal request and associates the bandwidth plan for application acceleration with the Smart Access Gateway instance after the request passes the check.</description></item>
        /// <item><description><b>true</b>: Sends a check request and performs only the check without associating the bandwidth plan for application acceleration with the Smart Access Gateway instance. The check items include whether required parameters are specified and whether the request format is valid. If the request fails the check, an error is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the bandwidth plan for application acceleration belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
