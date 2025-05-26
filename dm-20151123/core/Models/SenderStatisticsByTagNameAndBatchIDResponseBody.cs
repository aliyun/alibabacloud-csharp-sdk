// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsByTagNameAndBatchIDResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Data records</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SenderStatisticsByTagNameAndBatchIDResponseBodyData Data { get; set; }
        public class SenderStatisticsByTagNameAndBatchIDResponseBodyData : TeaModel {
            [NameInMap("stat")]
            [Validation(Required=false)]
            public List<SenderStatisticsByTagNameAndBatchIDResponseBodyDataStat> Stat { get; set; }
            public class SenderStatisticsByTagNameAndBatchIDResponseBodyDataStat : TeaModel {
                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-07-02</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Failure count</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("faildCount")]
                [Validation(Required=false)]
                public string FaildCount { get; set; }

                /// <summary>
                /// <para>Request count</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("requestCount")]
                [Validation(Required=false)]
                public string RequestCount { get; set; }

                /// <summary>
                /// <para>Success rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00%</para>
                /// </summary>
                [NameInMap("succeededPercent")]
                [Validation(Required=false)]
                public string SucceededPercent { get; set; }

                /// <summary>
                /// <para>Success count</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("successCount")]
                [Validation(Required=false)]
                public string SuccessCount { get; set; }

                /// <summary>
                /// <para>Invalid count</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("unavailableCount")]
                [Validation(Required=false)]
                public string UnavailableCount { get; set; }

                /// <summary>
                /// <para>Unavailability rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>0%</para>
                /// </summary>
                [NameInMap("unavailablePercent")]
                [Validation(Required=false)]
                public string UnavailablePercent { get; set; }

            }

        }

    }

}
