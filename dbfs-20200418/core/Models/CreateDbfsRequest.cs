// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class CreateDbfsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;cpuCoreCount&quot;:0.5,&quot;memorySize&quot;:512,&quot;pageCacheSize&quot;:128}</para>
        /// </summary>
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteSnapshot { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableRaid")]
        [Validation(Required=false)]
        public bool? EnableRaid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encryption")]
        [Validation(Required=false)]
        public bool? Encryption { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdbfs-001</para>
        /// </summary>
        [NameInMap("FsName")]
        [Validation(Required=false)]
        public string FsName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dbfs.small</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fb40826X</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        [NameInMap("RaidStripeUnitNumber")]
        [Validation(Required=false)]
        public int? RaidStripeUnitNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("SizeG")]
        [Validation(Required=false)]
        public int? SizeG { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s-y2vZ3********vvMilZ2hQ</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PostgreSQL</para>
        /// </summary>
        [NameInMap("UsedScene")]
        [Validation(Required=false)]
        public string UsedScene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
