// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAvailableHpnZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available HpnZone information for instances.</para>
        /// </summary>
        [NameInMap("InstanceHpnZones")]
        [Validation(Required=false)]
        public List<ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZones> InstanceHpnZones { get; set; }
        public class ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZones : TeaModel {
            /// <summary>
            /// <para>The list of available HpnZones for the instance.</para>
            /// </summary>
            [NameInMap("AvailableHpnZones")]
            [Validation(Required=false)]
            public List<ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZonesAvailableHpnZones> AvailableHpnZones { get; set; }
            public class ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZonesAvailableHpnZones : TeaModel {
                /// <summary>
                /// <para>The cluster ID, such as default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("HpnZone")]
                [Validation(Required=false)]
                public string HpnZone { get; set; }

            }

            /// <summary>
            /// <para>The KVCacheStore instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kvcs-xxxxx</para>
            /// </summary>
            [NameInMap("KvcsId")]
            [Validation(Required=false)]
            public string KvcsId { get; set; }

            /// <summary>
            /// <para>The zone ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. A request ID is returned regardless of whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FB5E9-F9E8-52F5-9C56-2CDF479CBEB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
