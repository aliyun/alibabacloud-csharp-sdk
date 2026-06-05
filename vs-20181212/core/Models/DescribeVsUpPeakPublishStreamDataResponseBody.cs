// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsUpPeakPublishStreamDataResponseBody : TeaModel {
        [NameInMap("DescribeVsUpPeakPublishStreamDatas")]
        [Validation(Required=false)]
        public DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatas DescribeVsUpPeakPublishStreamDatas { get; set; }
        public class DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatas : TeaModel {
            [NameInMap("DescribeVsUpPeakPublishStreamData")]
            [Validation(Required=false)]
            public List<DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatasDescribeVsUpPeakPublishStreamData> DescribeVsUpPeakPublishStreamData { get; set; }
            public class DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatasDescribeVsUpPeakPublishStreamData : TeaModel {
                [NameInMap("BandWidth")]
                [Validation(Required=false)]
                public string BandWidth { get; set; }

                [NameInMap("PeakTime")]
                [Validation(Required=false)]
                public string PeakTime { get; set; }

                [NameInMap("PublishStreamNum")]
                [Validation(Required=false)]
                public int? PublishStreamNum { get; set; }

                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public string QueryTime { get; set; }

                [NameInMap("StatName")]
                [Validation(Required=false)]
                public string StatName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27A3C548-A699-48F9-97CD-F35D81075AF3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
