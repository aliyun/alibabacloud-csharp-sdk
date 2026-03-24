// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetValidDeductInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetValidDeductInstancesResponseBodyData Data { get; set; }
        public class GetValidDeductInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Whether eligible for trial. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Eligible</description></item>
            /// <item><description><b>false</b>: Not eligible</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanTry")]
            [Validation(Required=false)]
            public bool? CanTry { get; set; }

            /// <summary>
            /// <para>List of resource package usage details.</para>
            /// </summary>
            [NameInMap("DeductPackageList")]
            [Validation(Required=false)]
            public List<GetValidDeductInstancesResponseBodyDataDeductPackageList> DeductPackageList { get; set; }
            public class GetValidDeductInstancesResponseBodyDataDeductPackageList : TeaModel {
                /// <summary>
                /// <para>Authorized consumption in the current billing cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CurrentPeriodUsed")]
                [Validation(Required=false)]
                public long? CurrentPeriodUsed { get; set; }

                /// <summary>
                /// <para>End time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1737734400000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>Total amount of the resource package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("InitCapacity")]
                [Validation(Required=false)]
                public double? InitCapacity { get; set; }

                /// <summary>
                /// <para>Resource package instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas_**_dp_cn-2***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Module code. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>POST_HOST</b>: Host and container protection</description></item>
                /// <item><description><b>CSPM</b>: Cloud product configuration check</description></item>
                /// <item><description><b>VUL</b>: Vulnerability scan</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POST_HOST</para>
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// <para>Authorized consumption up to the previous billing cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PeriodCapacity")]
                [Validation(Required=false)]
                public double? PeriodCapacity { get; set; }

                /// <summary>
                /// <para>Start timestamp (milliseconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1737734400000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Resource package status. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>valid</b>: Valid</description></item>
                /// <item><description><b>invalid</b>: Invalid</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D56A5C4-9C78-5EB1-9246-60B7FAECA1D5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
