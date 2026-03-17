// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AssociateSmartAGWithApplicationBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the bandwidth plan for application acceleration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abwp-7963l7iqnquyj3****</para>
        /// </summary>
        [NameInMap("ApplicationBandwidthPackageId")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The configuration of application acceleration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AssociateConfigs")]
        [Validation(Required=false)]
        public List<AssociateSmartAGWithApplicationBandwidthPackageRequestAssociateConfigs> AssociateConfigs { get; set; }
        public class AssociateSmartAGWithApplicationBandwidthPackageRequestAssociateConfigs : TeaModel {
            /// <summary>
            /// <para>The maximum bandwidth value for application acceleration. Unit: Mbit/s.</para>
            /// <remarks>
            /// <para> The maximum bandwidth value of each SAG instance cannot exceed that of the associated bandwidth plan for application acceleration.</para>
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
            /// <para>The ID of the SAG instance.</para>
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
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to precheck the request. Check items include permissions and the status of the specified cloud resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends the request. After the request passes the check, the bandwidth plan for application acceleration is associated with the SAG instance.</description></item>
        /// <item><description><b>true</b>: prechecks the request but does not associate the bandwidth plan for application acceleration with the SAG instance. If you use this value, the system checks the required parameters and the request syntax. If the request fails the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The region ID of the bandwidth plan for application acceleration.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
