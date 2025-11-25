// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrivateDnsStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AbnormalPrivateDnsCount")]
        [Validation(Required=false)]
        public long? AbnormalPrivateDnsCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("CreatedPrivateDnsCount")]
        [Validation(Required=false)]
        public long? CreatedPrivateDnsCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DomainNameTotalCount")]
        [Validation(Required=false)]
        public long? DomainNameTotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NewDomainNameTotalCount")]
        [Validation(Required=false)]
        public long? NewDomainNameTotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("NormalPrivateDnsCount")]
        [Validation(Required=false)]
        public long? NormalPrivateDnsCount { get; set; }

        [NameInMap("PrivateDnsRegionList")]
        [Validation(Required=false)]
        public List<DescribePrivateDnsStatisticsResponseBodyPrivateDnsRegionList> PrivateDnsRegionList { get; set; }
        public class DescribePrivateDnsStatisticsResponseBodyPrivateDnsRegionList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DomainNameCount")]
            [Validation(Required=false)]
            public long? DomainNameCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NewDomainNameCount")]
            [Validation(Required=false)]
            public long? NewDomainNameCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PrivateDnsCount")]
            [Validation(Required=false)]
            public long? PrivateDnsCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5716ED52-1B82-5DE1-8695-EFEC453D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
