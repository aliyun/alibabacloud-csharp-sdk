// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowTransition : TeaModel {
        /// <summary>
        /// <para>The average duration in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.9</para>
        /// </summary>
        [NameInMap("Avg")]
        [Validation(Required=false)]
        public double? Avg { get; set; }

        /// <summary>
        /// <para>The number of trajectories included in the statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The phase identifier. Valid values: dispatch_wait, start_wait, env_prepare, generation, agent_finish, reward, buffer_wait, logprob, ref_logprob, advantage, update, and e2e.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traj</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The Chinese name of the phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生成轨迹</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The maximum duration in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9.2</para>
        /// </summary>
        [NameInMap("Max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The P50 duration in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("P50")]
        [Validation(Required=false)]
        public double? P50 { get; set; }

        /// <summary>
        /// <para>The P90 duration in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.9</para>
        /// </summary>
        [NameInMap("P90")]
        [Validation(Required=false)]
        public double? P90 { get; set; }

        /// <summary>
        /// <para>The P99 duration in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.6</para>
        /// </summary>
        [NameInMap("P99")]
        [Validation(Required=false)]
        public double? P99 { get; set; }

        /// <summary>
        /// <para>The slowest 5 trajectories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;PromptUid&quot;:&quot;321fa56f-e1e5-4eb3-8047-db7a230c9a75&quot;,&quot;SampleIndex&quot;:&quot;2&quot;,&quot;Sec&quot;:9.2}]</para>
        /// </summary>
        [NameInMap("Slowest")]
        [Validation(Required=false)]
        public List<RLFlowSlowestItem> Slowest { get; set; }

    }

}
