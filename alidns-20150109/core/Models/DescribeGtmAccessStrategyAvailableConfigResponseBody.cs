// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The address pools.</para>
        /// </summary>
        [NameInMap("AddrPools")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools AddrPools { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPools : TeaModel {
            [NameInMap("AddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPoolsAddrPool> AddrPool { get; set; }
            public class DescribeGtmAccessStrategyAvailableConfigResponseBodyAddrPoolsAddrPool : TeaModel {
                /// <summary>
                /// <para>The ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hra0ix</para>
                /// </summary>
                [NameInMap("AddrPoolId")]
                [Validation(Required=false)]
                public string AddrPoolId { get; set; }

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AddrPoolName")]
                [Validation(Required=false)]
                public string AddrPoolName { get; set; }

            }

        }

        /// <summary>
        /// <para>The Domain Name System (DNS) request sources.</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyAvailableConfigResponseBodyLines Lines { get; set; }
        public class DescribeGtmAccessStrategyAvailableConfigResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyAvailableConfigResponseBodyLinesLine> Line { get; set; }
            public class DescribeGtmAccessStrategyAvailableConfigResponseBodyLinesLine : TeaModel {
                /// <summary>
                /// <para>The code of the parent line. No value is returned if no parent line exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>telecom</para>
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// <para>The group number of the DNS request source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ISP</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <para>The group name of the DNS request source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mainland China</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The code of the DNS request source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn_telecom_hubei</para>
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// <para>The name of the DNS request source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>South China</para>
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

                /// <summary>
                /// <para>The state of the line. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FORBIDDEN</b>: The line is unavailable.</description></item>
                /// <item><description><b>OPTIONAL</b>: The line is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FORBIDDEN</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2851BA9-CE56-49AF-8D12-4FC6A49EE688</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the global line is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("SuggestSetDefaultLine")]
        [Validation(Required=false)]
        public bool? SuggestSetDefaultLine { get; set; }

    }

}
