// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpPeakPublishStreamDataResponseBody : TeaModel {
        [NameInMap("DescribeUpPeakPublishStreamDatas")]
        [Validation(Required=false)]
        public DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatas DescribeUpPeakPublishStreamDatas { get; set; }
        public class DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatas : TeaModel {
            [NameInMap("DescribeUpPeakPublishStreamData")]
            [Validation(Required=false)]
            public List<DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatasDescribeUpPeakPublishStreamData> DescribeUpPeakPublishStreamData { get; set; }
            public class DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatasDescribeUpPeakPublishStreamData : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CFDE7AB-571A-14EA-B072-989FF753****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
