// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class UpdateDbfsRequest : TeaModel {
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
        /// <para>dbfs-GOrr********Yd0VLOyBpg</para>
        /// </summary>
        [NameInMap("FsId")]
        [Validation(Required=false)]
        public string FsId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dbfs.medium</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

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
        /// <b>Example:</b>
        /// <para>MySQL 5.7</para>
        /// </summary>
        [NameInMap("UsedScene")]
        [Validation(Required=false)]
        public string UsedScene { get; set; }

    }

}
