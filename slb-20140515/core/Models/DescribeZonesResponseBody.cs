// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A48D35FF-440A-4BC0-A4A2-A9BF69B7E43A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// <para>The name of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The list of secondary zones.</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The secondary zones.</para>
                /// </summary>
                [NameInMap("SlaveZones")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneSlaveZones SlaveZones { get; set; }
                public class DescribeZonesResponseBodyZonesZoneSlaveZones : TeaModel {
                    [NameInMap("SlaveZone")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneSlaveZonesSlaveZone> SlaveZone { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneSlaveZonesSlaveZone : TeaModel {
                        /// <summary>
                        /// <para>The name of the secondary zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Queries zones in a specified region.</para>
                        /// </summary>
                        [NameInMap("LocalName")]
                        [Validation(Required=false)]
                        public string LocalName { get; set; }

                        /// <summary>
                        /// <para>The ID of the secondary zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-g</para>
                        /// </summary>
                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
