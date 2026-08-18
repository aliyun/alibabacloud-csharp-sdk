// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetValidDeductInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetValidDeductInstancesResponseBodyData Data { get; set; }
        public class GetValidDeductInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message body.</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public GetValidDeductInstancesResponseBodyDataBody Body { get; set; }
            public class GetValidDeductInstancesResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <para>The data body.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public GetValidDeductInstancesResponseBodyDataBodyData Data { get; set; }
                public class GetValidDeductInstancesResponseBodyDataBodyData : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the account is eligible for a trial. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Eligible.</description></item>
                    /// <item><description><b>false</b>: Not eligible.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanTry")]
                    [Validation(Required=false)]
                    public bool? CanTry { get; set; }

                    /// <summary>
                    /// <para>The resource plan usage details.</para>
                    /// </summary>
                    [NameInMap("DeductPackageList")]
                    [Validation(Required=false)]
                    public List<GetValidDeductInstancesResponseBodyDataBodyDataDeductPackageList> DeductPackageList { get; set; }
                    public class GetValidDeductInstancesResponseBodyDataBodyDataDeductPackageList : TeaModel {
                        /// <summary>
                        /// <para>The number of authorizations consumed in the current metering cycle.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("CurrentPeriodUsed")]
                        [Validation(Required=false)]
                        public long? CurrentPeriodUsed { get; set; }

                        /// <summary>
                        /// <para>The end time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1737734400000</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <para>The total capacity of the resource plan.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("InitCapacity")]
                        [Validation(Required=false)]
                        public double? InitCapacity { get; set; }

                        /// <summary>
                        /// <para>The resource plan instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>apigateway-hz-96f6659a1490</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The module code. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>POST_HOST</b>: Host and container protection.</description></item>
                        /// <item><description><b>CSPM</b>: Cloud product configuration check.</description></item>
                        /// <item><description><b>VUL</b>: Vulnerability scanning.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>POST_HOST</para>
                        /// </summary>
                        [NameInMap("Module")]
                        [Validation(Required=false)]
                        public string Module { get; set; }

                        /// <summary>
                        /// <para>The number of authorizations consumed up to the previous billing cycle.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("PeriodCapacity")]
                        [Validation(Required=false)]
                        public double? PeriodCapacity { get; set; }

                        /// <summary>
                        /// <para>The start timestamp, in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1737734400000</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        /// <summary>
                        /// <para>The resource plan status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>valid</b>: Valid.</description></item>
                        /// <item><description><b>invalid</b>: Invalid.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CREATE_FAILED</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The Security Center request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A6FB9AC3-4431-538F-BA8A-2A13AEA208A4</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FBDD713-00A5-5C98-B661-3FD31A349B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current API call itself is successful. This does not indicate the success of subsequent business operations.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
