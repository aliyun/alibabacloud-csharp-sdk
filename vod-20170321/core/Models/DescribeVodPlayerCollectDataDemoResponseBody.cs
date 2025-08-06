// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodPlayerCollectDataDemoResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVodPlayerCollectDataDemoResponseBodyDataList> DataList { get; set; }
        public class DescribeVodPlayerCollectDataDemoResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Vv</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("ValueRatio")]
            [Validation(Required=false)]
            public double? ValueRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200.0</para>
            /// </summary>
            [NameInMap("ValueRefer")]
            [Validation(Required=false)]
            public double? ValueRefer { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
