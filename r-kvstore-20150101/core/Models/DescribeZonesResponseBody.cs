// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D42F072-72FE-4DC4-BB8E-64B1D298****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("KVStoreZone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesKVStoreZone> KVStoreZone { get; set; }
            public class DescribeZonesResponseBodyZonesKVStoreZone : TeaModel {
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SwitchNetwork")]
                [Validation(Required=false)]
                public bool? SwitchNetwork { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
