// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainAttackEventListResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeDomainAttackEventListResponseBodyDataList> DataList { get; set; }
        public class DescribeDomainAttackEventListResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1670918400</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1666083600</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
