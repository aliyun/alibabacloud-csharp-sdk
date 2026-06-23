// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The cluster specifications.</para>
        /// <list type="bullet">
        /// <item><description><para>For single-replica editions, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>S8</b></para>
        /// </description></item>
        /// <item><description><para><b>S16</b></para>
        /// </description></item>
        /// <item><description><para><b>S32</b></para>
        /// </description></item>
        /// <item><description><para><b>S64</b></para>
        /// </description></item>
        /// <item><description><para><b>S104</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For dual-replica editions, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>C8</b></para>
        /// </description></item>
        /// <item><description><para><b>C16</b></para>
        /// </description></item>
        /// <item><description><para><b>C32</b></para>
        /// </description></item>
        /// <item><description><para><b>C64</b></para>
        /// </description></item>
        /// <item><description><para><b>C104</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S8</para>
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp19lo45sy98x****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// <list type="bullet">
        /// <item><description><para>For single-replica editions, the valid values are integers from 1 to 48.</para>
        /// </description></item>
        /// <item><description><para>For dual-replica editions, the valid values are integers from 1 to 24.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// <para>The storage space of a single node. Unit: GB.</para>
        /// <para>Valid values: 100 to 32000.</para>
        /// <remarks>
        /// <para>The step size is 100 GB.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// <para>The storage class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CloudESSD</b>: ESSD PL1 disk.</para>
        /// </description></item>
        /// <item><description><para><b>CloudESSD_PL2</b>: ESSD PL2 disk.</para>
        /// </description></item>
        /// <item><description><para><b>CloudESSD_PL3</b>: ESSD PL3 disk.</para>
        /// </description></item>
        /// <item><description><para><b>CloudEfficiency</b>: ultra disk.</para>
        /// </description></item>
        /// <item><description><para><b>CloudSSD</b>: standard SSD.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudESSD</para>
        /// </summary>
        [NameInMap("DbNodeStorageType")]
        [Validation(Required=false)]
        public string DbNodeStorageType { get; set; }

        /// <summary>
        /// <para>The write-inaccessible window. Separate the start time and the end time with a comma. Use the ISO 8601 format for the time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-09T20:00:00+08:00,2024-07-09T21:00:00+08:00</para>
        /// </summary>
        [NameInMap("DisableWriteWindows")]
        [Validation(Required=false)]
        public string DisableWriteWindows { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
