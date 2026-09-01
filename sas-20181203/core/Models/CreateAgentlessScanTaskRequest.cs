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
        /// <para>The image retention period, in days. This parameter takes effect only for host detection and does not take effect for user snapshot detection or user custom image detection.</para>
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
        /// <para>The region ID of the instance to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b> (default): China.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cost-saving mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReleaseAfterScan")]
        [Validation(Required=false)]
        public bool? ReleaseAfterScan { get; set; }

        /// <summary>
        /// <para>Specifies whether to detect data cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Detected.</description></item>
        /// <item><description><b>false</b>: Not detected.</description></item>
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
        /// <item><description><b>1</b>: Host detection - detection by snapshot.</description></item>
        /// <item><description><b>2</b>: Host detection - detection by image.</description></item>
        /// <item><description><b>3</b>: User snapshot detection.</description></item>
        /// <item><description><b>2</b>: User custom image detection.</description></item>
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
        /// <para>The UUIDs of the assets to be detected.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain the UUIDs of servers.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
