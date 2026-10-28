// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAvailableHpnZonesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the KVCacheStore instances. Separate multiple IDs with commas. You can specify 1 to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KvcsIds")]
        [Validation(Required=false)]
        public List<string> KvcsIds { get; set; }

        /// <summary>
        /// <para>The region ID, such as cn-hangzhou.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
