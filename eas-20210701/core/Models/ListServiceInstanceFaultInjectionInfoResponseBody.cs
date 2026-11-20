// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceInstanceFaultInjectionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of injected faults.</para>
        /// </summary>
        [NameInMap("FaultInfoList")]
        [Validation(Required=false)]
        public List<ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoList> FaultInfoList { get; set; }
        public class ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoList : TeaModel {
            /// <summary>
            /// <para>Detailed parameters for each fault type:</para>
            /// <ol>
            /// <item><description>CpuFullloadTask (CPU full load fault)
            /// <c>{   &quot;FaultType&quot;: &quot;CpuFullloadTask&quot;,   &quot;FaultArgs&quot;: {  &quot;FaultAction&quot;: &quot;fullload&quot;,  &quot;CpuPercent&quot;: 50   } }</c></description></item>
            /// <item><description>MemLoadTask (memory load fault)
            /// <c>{   &quot;FaultType&quot;: &quot;MemLoadTask&quot;,   &quot;FaultArgs&quot;: {  &quot;FaultAction&quot;: &quot;load&quot;,  &quot;MemPercent&quot;: 80   } }</c></description></item>
            /// <item><description>NetworkTask (network fault)
            /// 3.a. NetworkDelayAction (network delay)
            /// <c>{   &quot;FaultType&quot;: &quot;NetworkTask&quot;,   &quot;FaultArgs&quot;: {  &quot;FaultAction&quot;: &quot;delay&quot;,  &quot;Time&quot;: 3000,  &quot;Offset&quot;: 100   } }</c>
            /// 3.b. NetworkCorruptAction (network packet corruption)
            /// <c>{   &quot;FaultType&quot;: &quot;NetworkTask&quot;,   &quot;FaultArgs&quot;: {  &quot;FaultAction&quot;: &quot;corrupt&quot;,  &quot;Percent&quot;: 50   } }</c>
            /// 3.c. NetworkLossAction (network packet loss)
            /// <c>{   &quot;FaultType&quot;: &quot;NetworkTask&quot;,   &quot;FaultArgs&quot;: {  &quot;FaultAction&quot;: &quot;loss&quot;,  &quot;Percent&quot;: 30   } }</c></description></item>
            /// <item><description>DiskBurnTask (disk read/write fault)
            /// <c>{   &quot;FaultType&quot;: &quot;DiskBurnTask&quot;,   &quot;FaultArgs&quot;: {  &quot;FaultAction&quot;: &quot;burn&quot;,  &quot;Read&quot;: true,  &quot;Write&quot;: true,  &quot;Size&quot;: 100   } }</c></description></item>
            /// <item><description>DiskFillTask (disk fill fault)
            /// <c>{   &quot;FaultType&quot;: &quot;DiskFillTask&quot;,   &quot;FaultArgs&quot;: {  &quot;FaultAction&quot;: &quot;fill&quot;,  &quot;Percent&quot;: 80   } }</c></description></item>
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
                /// <para>The fault status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FaultNotInjected: The task is created but the fault is not injected.</description></item>
                /// <item><description>FaultInjectedSuccess: The fault is successfully injected.</description></item>
                /// <item><description>FaultInjectedFailure: The fault injection failed, which may be caused by parameter errors or system issues.</description></item>
                /// </list>
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
            /// <para>The fault type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CpuFullloadTask: CPU full load fault.</description></item>
            /// <item><description>MemLoadTask: memory load fault.</description></item>
            /// <item><description>NetworkTask: network fault.</description></item>
            /// <item><description>DiskBurnTask: disk read/write fault.</description></item>
            /// <item><description>DiskFillTask: disk fill fault.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DiskFillTask</para>
            /// </summary>
            [NameInMap("FaultType")]
            [Validation(Required=false)]
            public string FaultType { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
