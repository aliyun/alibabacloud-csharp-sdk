// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAvailableHpnZonesResponseBody : TeaModel {
        [NameInMap("InstanceHpnZones")]
        [Validation(Required=false)]
        public List<ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZones> InstanceHpnZones { get; set; }
        public class ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZones : TeaModel {
            [NameInMap("AvailableHpnZones")]
            [Validation(Required=false)]
            public List<ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZonesAvailableHpnZones> AvailableHpnZones { get; set; }
            public class ListKVCacheStoreAvailableHpnZonesResponseBodyInstanceHpnZonesAvailableHpnZones : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("HpnZone")]
                [Validation(Required=false)]
                public string HpnZone { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kvcs-xxxxx</para>
            /// </summary>
            [NameInMap("KvcsId")]
            [Validation(Required=false)]
            public string KvcsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>019FB5E9-F9E8-52F5-9C56-2CDF479CBEB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
