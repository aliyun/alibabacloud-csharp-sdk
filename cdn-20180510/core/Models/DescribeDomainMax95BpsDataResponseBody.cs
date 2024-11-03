// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMax95BpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the 95th percentile bandwidth.</para>
        /// </summary>
        [NameInMap("DetailData")]
        [Validation(Required=false)]
        public DescribeDomainMax95BpsDataResponseBodyDetailData DetailData { get; set; }
        public class DescribeDomainMax95BpsDataResponseBodyDetailData : TeaModel {
            [NameInMap("Max95Detail")]
            [Validation(Required=false)]
            public List<DescribeDomainMax95BpsDataResponseBodyDetailDataMax95Detail> Max95Detail { get; set; }
            public class DescribeDomainMax95BpsDataResponseBodyDetailDataMax95Detail : TeaModel {
                /// <summary>
                /// <para>Region of the 95th percentile bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <para>The 95th percentile bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16777590.28</para>
                /// </summary>
                [NameInMap("Max95Bps")]
                [Validation(Required=false)]
                public float? Max95Bps { get; set; }

                /// <summary>
                /// <para>Time of the 95th percentile bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-11T21:05:00Z</para>
                /// </summary>
                [NameInMap("Max95BpsPeakTime")]
                [Validation(Required=false)]
                public string Max95BpsPeakTime { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-11T21:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The 95th percentile bandwidth in the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16777590.28</para>
        /// </summary>
        [NameInMap("DomesticMax95Bps")]
        [Validation(Required=false)]
        public string DomesticMax95Bps { get; set; }

        /// <summary>
        /// <para>The end of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-11T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The 95th percentile bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16777590.28</para>
        /// </summary>
        [NameInMap("Max95Bps")]
        [Validation(Required=false)]
        public string Max95Bps { get; set; }

        /// <summary>
        /// <para>The 95th percentile bandwidth outside the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OverseasMax95Bps")]
        [Validation(Required=false)]
        public string OverseasMax95Bps { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
