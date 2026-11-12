// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKVCacheInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The description of the KVCache instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test cache instance</para>
        /// </summary>
        [NameInMap("KVCacheInstanceDescription")]
        [Validation(Required=false)]
        public string KVCacheInstanceDescription { get; set; }

        /// <summary>
        /// <para>The KVCache instance IDs. Separate multiple instance IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkv-123456,pkv-789012</para>
        /// </summary>
        [NameInMap("KVCacheInstanceIds")]
        [Validation(Required=false)]
        public string KVCacheInstanceIds { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the associated PolarDB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-123456</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

    }

}
