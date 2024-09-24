// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAgentlessScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>Identification of asset selection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENTLESS_SCAN_ONCE_TASK_1720145******</para>
        /// </summary>
        [NameInMap("AssetSelectionType")]
        [Validation(Required=false)]
        public string AssetSelectionType { get; set; }

        /// <summary>
        /// <para>The retention period of images. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoDeleteDays")]
        [Validation(Required=false)]
        public int? AutoDeleteDays { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cost-saving mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReleaseAfterScan")]
        [Validation(Required=false)]
        public bool? ReleaseAfterScan { get; set; }

        /// <summary>
        /// <para>Specifies whether to check data disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScanDataDisk")]
        [Validation(Required=false)]
        public bool? ScanDataDisk { get; set; }

        /// <summary>
        /// <para>The type of the detection object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: image</description></item>
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
        /// <para>The UUIDs of the assets on which you want to run the detection task.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
