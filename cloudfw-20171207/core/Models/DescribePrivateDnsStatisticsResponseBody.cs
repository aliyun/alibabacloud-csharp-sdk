// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrivateDnsStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of private DNS instances in an abnormal state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AbnormalPrivateDnsCount")]
        [Validation(Required=false)]
        public long? AbnormalPrivateDnsCount { get; set; }

        /// <summary>
        /// <para>The number of created private DNS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("CreatedPrivateDnsCount")]
        [Validation(Required=false)]
        public long? CreatedPrivateDnsCount { get; set; }

        /// <summary>
        /// <para>The total number of configured domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DomainNameTotalCount")]
        [Validation(Required=false)]
        public long? DomainNameTotalCount { get; set; }

        /// <summary>
        /// <para>The number of configured domain names that were created within the specified time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NewDomainNameTotalCount")]
        [Validation(Required=false)]
        public long? NewDomainNameTotalCount { get; set; }

        /// <summary>
        /// <para>The number of private DNS instances in a normal state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("NormalPrivateDnsCount")]
        [Validation(Required=false)]
        public long? NormalPrivateDnsCount { get; set; }

        /// <summary>
        /// <para>A list of DNS regions.</para>
        /// </summary>
        [NameInMap("PrivateDnsRegionList")]
        [Validation(Required=false)]
        public List<DescribePrivateDnsStatisticsResponseBodyPrivateDnsRegionList> PrivateDnsRegionList { get; set; }
        public class DescribePrivateDnsStatisticsResponseBodyPrivateDnsRegionList : TeaModel {
            /// <summary>
            /// <para>The number of configured domain names for private DNS in the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DomainNameCount")]
            [Validation(Required=false)]
            public long? DomainNameCount { get; set; }

            /// <summary>
            /// <para>The number of configured domain names that were created in the region within the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NewDomainNameCount")]
            [Validation(Required=false)]
            public long? NewDomainNameCount { get; set; }

            /// <summary>
            /// <para>The number of private DNS instances in the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PrivateDnsCount")]
            [Validation(Required=false)]
            public long? PrivateDnsCount { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5716ED52-1B82-5DE1-8695-EFEC453D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
