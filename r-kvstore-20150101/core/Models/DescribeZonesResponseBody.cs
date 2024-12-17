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

        /// <summary>
        /// <para>The queried zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("KVStoreZone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesKVStoreZone> KVStoreZone { get; set; }
            public class DescribeZonesResponseBodyZonesKVStoreZone : TeaModel {
                /// <summary>
                /// <para>Indicates whether ApsaraDB for Redis instances can be created in the current zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: ApsaraDB for Redis instances cannot be created in the current zone.</description></item>
                /// <item><description><b>false</b>: ApsaraDB for Redis instances can be created in the current zone.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the zone is managed by ApsaraDB RDS. The return value of this parameter is <b>true</b> in ApsaraDB for Redis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-huhehaote</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Indicates whether the network type of the instance can be changed from the classic network to Virtual Private Cloud (VPC). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The network type of the instance can be changed from the classic network to VPC.</description></item>
                /// <item><description><b>false</b>: The network type of the instance cannot be changed from the classic network to VPC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SwitchNetwork")]
                [Validation(Required=false)]
                public bool? SwitchNetwork { get; set; }

                /// <summary>
                /// <para>The ID of the zone within the specified region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-huhehaote-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The name of the zone within the specified region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hohhot Zone B</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
