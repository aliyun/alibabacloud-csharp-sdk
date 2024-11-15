// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetKafkaClientIpResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKafkaClientIpResponseBodyData Data { get; set; }
        public class GetKafkaClientIpResponseBodyData : TeaModel {
            /// <summary>
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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>58.210.117.154</para>
                            /// </summary>
                            [NameInMap("Ip")]
                            [Validation(Required=false)]
                            public string Ip { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Num")]
                            [Validation(Required=false)]
                            public long? Num { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OFFSET_COMMIT</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1716343502000</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SearchTimeRange")]
            [Validation(Required=false)]
            public int? SearchTimeRange { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1716343501000</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public long? StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TimeLimitDay")]
            [Validation(Required=false)]
            public int? TimeLimitDay { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E57A8862-DF68-4055-8E55-B80CB4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
