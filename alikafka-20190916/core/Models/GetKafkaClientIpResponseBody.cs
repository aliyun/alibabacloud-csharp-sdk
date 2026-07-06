// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetKafkaClientIpResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKafkaClientIpResponseBodyData Data { get; set; }
        public class GetKafkaClientIpResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If this value is true, it indicates that the minor version is not the latest version.</para>
            /// <remarks>
            /// <para>If your server minor version is not the latest version, the sampling logs may not be accurate enough, resulting in less precise IP information statistics. Therefore, it is recommended that you upgrade the server minor version as soon as possible.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public bool? Alert { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetKafkaClientIpResponseBodyDataData Data { get; set; }
            public class GetKafkaClientIpResponseBodyDataData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<GetKafkaClientIpResponseBodyDataDataData> Data { get; set; }
                public class GetKafkaClientIpResponseBodyDataDataData : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public GetKafkaClientIpResponseBodyDataDataDataData Data { get; set; }
                    public class GetKafkaClientIpResponseBodyDataDataDataData : TeaModel {
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public List<GetKafkaClientIpResponseBodyDataDataDataDataData> Data { get; set; }
                        public class GetKafkaClientIpResponseBodyDataDataDataDataData : TeaModel {
                            [NameInMap("Ip")]
                            [Validation(Required=false)]
                            public string Ip { get; set; }

                            [NameInMap("Num")]
                            [Validation(Required=false)]
                            public long? Num { get; set; }

                        }

                    }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>End time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716343502000</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

            /// <summary>
            /// <para>The time range for querying client IPs.</para>
            /// <remarks>
            /// <para>This range is 1 hour. If the start time and end time you enter exceed 1 hour, only data within 1 hour will be queried.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SearchTimeRange")]
            [Validation(Required=false)]
            public int? SearchTimeRange { get; set; }

            /// <summary>
            /// <para>Start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716343501000</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public long? StartDate { get; set; }

            /// <summary>
            /// <para>The date range for querying client IPs.</para>
            /// <remarks>
            /// <para>This range is 7 days. If the start time and end time you enter exceed 7 days, only data within 7 days will be queried.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TimeLimitDay")]
            [Validation(Required=false)]
            public int? TimeLimitDay { get; set; }

        }

        /// <summary>
        /// <para>The prompt message for the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E57A8862-DF68-4055-8E55-B80CB4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
