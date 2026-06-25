// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceInstanceFaultInjectionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of injected faults.</para>
        /// </summary>
        [NameInMap("FaultInfoList")]
        [Validation(Required=false)]
        public List<ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoList> FaultInfoList { get; set; }
        public class ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoList : TeaModel {
            /// <summary>
            /// <para>The parameters for each fault type.</para>
            /// <ol>
            /// <item><description><para>CpuFullloadTask (CPU full load fault)
            /// <c>{ &quot;FaultType&quot;: &quot;CpuFullloadTask&quot;, &quot;FaultArgs&quot;: { &quot;FaultAction&quot;: &quot;fullload&quot;, &quot;CpuPercent&quot;: 50 } }</c></para>
            /// </description></item>
            /// <item><description><para>MemLoadTask (Memory load fault)
            /// <c>{ &quot;FaultType&quot;: &quot;MemLoadTask&quot;, &quot;FaultArgs&quot;: { &quot;FaultAction&quot;: &quot;load&quot;, &quot;MemPercent&quot;: 80 } }</c></para>
            /// </description></item>
            /// <item><description><para>NetworkTask (Network fault)
            /// 3.a. NetworkDelayAction (Network delay)
            /// <c>{ &quot;FaultType&quot;: &quot;NetworkTask&quot;, &quot;FaultArgs&quot;: { &quot;FaultAction&quot;: &quot;delay&quot;, &quot;Time&quot;: 3000, &quot;Offset&quot;: 100 } }</c>
            /// 3.b. NetworkCorruptAction (Network packet corruption)
            /// <c>{ &quot;FaultType&quot;: &quot;NetworkTask&quot;, &quot;FaultArgs&quot;: { &quot;FaultAction&quot;: &quot;corrupt&quot;, &quot;Percent&quot;: 50 } }</c>
            /// 3.c. NetworkLossAction (Network packet loss)
            /// <c>{ &quot;FaultType&quot;: &quot;NetworkTask&quot;, &quot;FaultArgs&quot;: { &quot;FaultAction&quot;: &quot;loss&quot;, &quot;Percent&quot;: 30 } }</c></para>
            /// </description></item>
            /// <item><description><para>DiskBurnTask (Disk read/write fault)
            /// <c>{ &quot;FaultType&quot;: &quot;DiskBurnTask&quot;, &quot;FaultArgs&quot;: { &quot;FaultAction&quot;: &quot;burn&quot;, &quot;Read&quot;: true, &quot;Write&quot;: true, &quot;Size&quot;: 100 } }</c></para>
            /// </description></item>
            /// <item><description><para>DiskFillTask (Disk fill fault)
            /// <c>{ &quot;FaultType&quot;: &quot;DiskFillTask&quot;, &quot;FaultArgs&quot;: { &quot;FaultAction&quot;: &quot;fill&quot;, &quot;Percent&quot;: 80 } }</c></para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;FaultType&quot;: &quot;DiskBurnTask&quot;,
            ///   &quot;FaultArgs&quot;: {
            ///     &quot;FaultAction&quot;: &quot;burn&quot;,
            ///     &quot;Read&quot;: true,
            ///     &quot;Write&quot;: true,
            ///     &quot;Size&quot;: 100
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("FaultArgs")]
            [Validation(Required=false)]
            public object FaultArgs { get; set; }

            /// <summary>
            /// <para>The fault status.</para>
            /// </summary>
            [NameInMap("FaultStatus")]
            [Validation(Required=false)]
            public ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoListFaultStatus FaultStatus { get; set; }
            public class ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoListFaultStatus : TeaModel {
                /// <summary>
                /// <para>The status of the fault. Valid values:</para>
                /// <ol>
                /// <item><description><para>FaultNotInjected: The task was created, but the fault was not successfully injected.</para>
                /// </description></item>
                /// <item><description><para>FaultInjectedSuccess: The fault was successfully injected.</para>
                /// </description></item>
                /// <item><description><para>FaultInjectedFailure: The fault injection failed. The failure may be caused by parameter errors or system issues.</para>
                /// </description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>FaultInjectedSuccess</para>
                /// </summary>
                [NameInMap("FaultStatus")]
                [Validation(Required=false)]
                public string FaultStatus { get; set; }

                /// <summary>
                /// <para>The description of the fault injection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Network interface not found</para>
                /// </summary>
                [NameInMap("FaultStatusMessage")]
                [Validation(Required=false)]
                public string FaultStatusMessage { get; set; }

            }

            /// <summary>
            /// <para>The fault type. Valid values:CpuFullloadTask: a CPU full load fault.MemLoadTask: a memory load fault.NetworkTask: a network fault.DiskBurnTask: a disk read/write fault.DiskFillTask: a disk fill fault.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DiskFillTask</para>
            /// </summary>
            [NameInMap("FaultType")]
            [Validation(Required=false)]
            public string FaultType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
