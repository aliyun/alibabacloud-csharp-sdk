// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAvailableHpnZonesRequest : TeaModel {
        /// <summary>
        /// <para>The list of KVCacheStore instance IDs, separated by commas. You can specify a minimum of 1 and a maximum of 100 instance IDs.</para>
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
