// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeRCAvailableResourceResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeRCAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableResources")]
            [Validation(Required=false)]
            public List<DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResources> AvailableResources { get; set; }
            public class DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResources : TeaModel {
                [NameInMap("SupportedResources")]
                [Validation(Required=false)]
                public List<DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResourcesSupportedResources> SupportedResources { get; set; }
                public class DescribeRCAvailableResourceResponseBodyAvailableZonesAvailableResourcesSupportedResources : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("QuotaStatus")]
                    [Validation(Required=false)]
                    public string QuotaStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>WithStock</para>
                    /// </summary>
                    [NameInMap("StatusCategory")]
                    [Validation(Required=false)]
                    public string StatusCategory { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>GiB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mysql.x4.4xlarge.7cm</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>InstanceType</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0041D94C-FB92-4C49-B115-259DA1C*****</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WithStock</para>
            /// </summary>
            [NameInMap("StatusCategory")]
            [Validation(Required=false)]
            public string StatusCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-e</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0041D94C-FB92-4C49-B115-259DA1C*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
