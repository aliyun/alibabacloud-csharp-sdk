// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateFaultInjectionRequest : TeaModel {
        /// <summary>
        /// <para>The parameters for each fault type are described as follows:</para>
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
        ///   &quot;FaultType&quot;: &quot;DiskFillTask&quot;,
        ///   &quot;FaultArgs&quot;: {
        ///     &quot;FaultAction&quot;: &quot;fill&quot;,
        ///     &quot;Percent&quot;: 80
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("FaultArgs")]
        [Validation(Required=false)]
        public object FaultArgs { get; set; }

        /// <summary>
        /// <para>The fault type.
        /// Device faults: 1. CPU full load fault. 2. Memory load fault. 3. Network fault. 4. Disk read/write fault. 5. Disk fill fault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CpuFullloadTask</para>
        /// </summary>
        [NameInMap("FaultType")]
        [Validation(Required=false)]
        public string FaultType { get; set; }

    }

}
