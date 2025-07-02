// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the EIPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;106.14.194.193\&quot;]</para>
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEnsEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEnsEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("IpStatus")]
                [Validation(Required=false)]
                public string IpStatus { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Standby")]
                [Validation(Required=false)]
                public bool? Standby { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTags Tags { get; set; }
                public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTagsTag> Tag { get; set; }
                    public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddressTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <term><b>Obsolete</b></term>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagKey { get; set; }

                        /// <term><b>Obsolete</b></term>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string TagValue { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number. Valid values: an integer that is greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: <b>10</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8629F679-B51D-4194-A1CC-5D8F504C362B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
