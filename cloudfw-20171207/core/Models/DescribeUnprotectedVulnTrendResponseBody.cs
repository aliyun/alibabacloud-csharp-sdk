// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUnprotectedVulnTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CurProtectedCnt")]
        [Validation(Required=false)]
        public int? CurProtectedCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CurUnprotectedCnt")]
        [Validation(Required=false)]
        public int? CurUnprotectedCnt { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeUnprotectedVulnTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeUnprotectedVulnTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProtectedVulnCnt")]
            [Validation(Required=false)]
            public int? ProtectedVulnCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1525833105</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnprotectedVulnCnt")]
            [Validation(Required=false)]
            public int? UnprotectedVulnCnt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1731551104</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>05BEF2B5-EAAA-509D-9824-E3C7DC17****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1749434787</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
