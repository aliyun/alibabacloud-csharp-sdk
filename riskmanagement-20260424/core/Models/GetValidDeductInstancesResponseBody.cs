// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetValidDeductInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetValidDeductInstancesResponseBodyData Data { get; set; }
        public class GetValidDeductInstancesResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public GetValidDeductInstancesResponseBodyDataBody Body { get; set; }
            public class GetValidDeductInstancesResponseBodyDataBody : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public GetValidDeductInstancesResponseBodyDataBodyData Data { get; set; }
                public class GetValidDeductInstancesResponseBodyDataBodyData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanTry")]
                    [Validation(Required=false)]
                    public bool? CanTry { get; set; }

                    [NameInMap("DeductPackageList")]
                    [Validation(Required=false)]
                    public List<GetValidDeductInstancesResponseBodyDataBodyDataDeductPackageList> DeductPackageList { get; set; }
                    public class GetValidDeductInstancesResponseBodyDataBodyDataDeductPackageList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("CurrentPeriodUsed")]
                        [Validation(Required=false)]
                        public long? CurrentPeriodUsed { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1737734400000</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("InitCapacity")]
                        [Validation(Required=false)]
                        public double? InitCapacity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>apigateway-hz-96f6659a1490</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>POST_HOST</para>
                        /// </summary>
                        [NameInMap("Module")]
                        [Validation(Required=false)]
                        public string Module { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("PeriodCapacity")]
                        [Validation(Required=false)]
                        public double? PeriodCapacity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1737734400000</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CREATE_FAILED</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A6FB9AC3-4431-538F-BA8A-2A13AEA208A4</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FBDD713-00A5-5C98-B661-3FD31A349B6E</para>
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
