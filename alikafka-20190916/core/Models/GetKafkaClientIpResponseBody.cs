// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetKafkaClientIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKafkaClientIpResponseBodyData Data { get; set; }
        public class GetKafkaClientIpResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The value true indicates that the broker is not of the latest minor version.</para>
            /// <remarks>
            /// <para> If the broker is not of the latest minor version, the sampled logs may not be accurate. This may cause inaccurate IP information. Therefore, we recommend that you update your broker to the latest version at the earliest opportunity.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Alert")]
            [Validation(Required=false)]
            public bool? Alert { get; set; }

            /// <summary>
            /// <para>The data returned.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetKafkaClientIpResponseBodyDataData Data { get; set; }
            public class GetKafkaClientIpResponseBodyDataData : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<GetKafkaClientIpResponseBodyDataDataData> Data { get; set; }
                public class GetKafkaClientIpResponseBodyDataDataData : TeaModel {
                    /// <summary>
                    /// <para>The response parameters.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public GetKafkaClientIpResponseBodyDataDataDataData Data { get; set; }
                    public class GetKafkaClientIpResponseBodyDataDataDataData : TeaModel {
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public List<GetKafkaClientIpResponseBodyDataDataDataDataData> Data { get; set; }
                        public class GetKafkaClientIpResponseBodyDataDataDataDataData : TeaModel {
                            /// <summary>
                            /// <para>The IP address of the client.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>58.210.117.154</para>
                            /// </summary>
                            [NameInMap("Ip")]
                            [Validation(Required=false)]
                            public string Ip { get; set; }

                            /// <summary>
                            /// <para>The statistics.</para>
                            /// <remarks>
                            /// <para> The value of this parameter indicates the number of connections on different ports of the IP address within the specified period of time.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Num")]
                            [Validation(Required=false)]
                            public long? Num { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The request name.</para>
                    /// <remarks>
                    /// <para> The value of this parameter indicates the type of request that the client sends to the broker within the specified period of time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OFFSET_COMMIT</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The end of the date range within which data is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716343502000</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

            /// <summary>
            /// <para>The time range within which the client IP addresses are queried.</para>
            /// <remarks>
            /// <para> The valid value is 1 hour. If the beginning of the time range to query and the end of the time range to query exceeds 1 hour, only data within 1 hour is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SearchTimeRange")]
            [Validation(Required=false)]
            public int? SearchTimeRange { get; set; }

            /// <summary>
            /// <para>The beginning of the date range within which data is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716343501000</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public long? StartDate { get; set; }

            /// <summary>
            /// <para>The date range within which the client IP addresses are queried.</para>
            /// <remarks>
            /// <para> The valid value is 7 days. If the beginning of the date range to query and the end of the date range to query exceeds 7 days, only data within 7 days is returned.</para>
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
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
