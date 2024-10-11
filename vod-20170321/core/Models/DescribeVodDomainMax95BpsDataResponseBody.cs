// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainMax95BpsDataResponseBody : TeaModel {
        [NameInMap("DetailData")]
        [Validation(Required=false)]
        public DescribeVodDomainMax95BpsDataResponseBodyDetailData DetailData { get; set; }
        public class DescribeVodDomainMax95BpsDataResponseBodyDetailData : TeaModel {
            [NameInMap("Max95Detail")]
            [Validation(Required=false)]
            public List<DescribeVodDomainMax95BpsDataResponseBodyDetailDataMax95Detail> Max95Detail { get; set; }
            public class DescribeVodDomainMax95BpsDataResponseBodyDetailDataMax95Detail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16777590.28</para>
                /// </summary>
                [NameInMap("Max95Bps")]
                [Validation(Required=false)]
                public float? Max95Bps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2015-12-11T21:05:00Z</para>
                /// </summary>
                [NameInMap("Max95BpsPeakTime")]
                [Validation(Required=false)]
                public string Max95BpsPeakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-18 10:11:32</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16777590.28</para>
        /// </summary>
        [NameInMap("DomesticMax95Bps")]
        [Validation(Required=false)]
        public string DomesticMax95Bps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2017-01-11T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16777590.28</para>
        /// </summary>
        [NameInMap("Max95Bps")]
        [Validation(Required=false)]
        public string Max95Bps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OverseasMax95Bps")]
        [Validation(Required=false)]
        public string OverseasMax95Bps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
