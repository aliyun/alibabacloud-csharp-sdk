// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAgentlessScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The asset selection identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENTLESS_SCAN_ONCE_TASK_1720145******</para>
        /// </summary>
        [NameInMap("AssetSelectionType")]
        [Validation(Required=false)]
        public string AssetSelectionType { get; set; }

        /// <summary>
        /// <para>The retention period of the image, in days. This parameter takes effect only for host detection and does not take effect for user snapshot detection or custom image detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoDeleteDays")]
        [Validation(Required=false)]
        public int? AutoDeleteDays { get; set; }

        /// <summary>
        /// <para>The idempotency key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66a9c708-d4a4-4fe</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The source of the API call. This parameter is used to collect statistics on the number of scan tasks and the amount of scanned data by source. If this parameter is not specified, it is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-console</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is usually automatically populated by the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cost-saving mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable.</description></item>
        /// <item><description><b>false</b>: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReleaseAfterScan")]
        [Validation(Required=false)]
        public bool? ReleaseAfterScan { get; set; }

        /// <summary>
        /// <para>The region ID of the resource to be detected, such as cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to detect data cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScanDataDisk")]
        [Validation(Required=false)]
        public bool? ScanDataDisk { get; set; }

        /// <summary>
        /// <para>The target type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Host detection by using snapshots.</description></item>
        /// <item><description><b>2</b>: Host detection by using images.</description></item>
        /// <item><description><b>3</b>: User snapshot detection.</description></item>
        /// <item><description><b>2</b>: Custom image detection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        /// <summary>
        /// <para>The list of targets for image security remediation. Each target specifies the source image, the region, the name of the remediated image, and the identifiers of the vulnerabilities to be remediated.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateAgentlessScanTaskRequestTargets> Targets { get; set; }
        public class CreateAgentlessScanTaskRequestTargets : TeaModel {
            /// <summary>
            /// <para>The ID of the source ECS custom image to be remediated. The image must be located in the region specified by the RegionId parameter of the target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1example123456789</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the source ECS custom image to be remediated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source-image</para>
            /// </summary>
            [NameInMap("OriginImageName")]
            [Validation(Required=false)]
            public string OriginImageName { get; set; }

            /// <summary>
            /// <para>The name of the ECS image generated after the remediation is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>patched-image-20260909</para>
            /// </summary>
            [NameInMap("OutputImageName")]
            [Validation(Required=false)]
            public string OutputImageName { get; set; }

            /// <summary>
            /// <para>The region ID of the source image to be remediated, such as cn-hangzhou.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of vulnerability identifiers to be remediated in this task. You must specify at least one vulnerability identifier. The identifiers cannot be empty or duplicate.</para>
            /// </summary>
            [NameInMap("VulnerabilityIds")]
            [Validation(Required=false)]
            public List<string> VulnerabilityIds { get; set; }

        }

        /// <summary>
        /// <para>The UUIDs of the assets to be detected.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain the UUID of the server.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
