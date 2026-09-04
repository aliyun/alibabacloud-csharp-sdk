// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowStuckItem : TeaModel {
        /// <summary>
        /// <para>The number of idle seconds since NowMs. This value is the descending sort key of the Stuck list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdleSec")]
        [Validation(Required=false)]
        public long? IdleSec { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp of the last event, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787293215480</para>
        /// </summary>
        [NameInMap("LastTsMs")]
        [Validation(Required=false)]
        public long? LastTsMs { get; set; }

        /// <summary>
        /// <para>The current milestone where the entry is staying. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>已生成未下发: Generated but not delivered.</description></item>
        /// <item><description>已下发未启动: Delivered but not started.</description></item>
        /// <item><description>已启动待生成: Started and pending generation.</description></item>
        /// <item><description>生成中: Generating.</description></item>
        /// <item><description>Rollout完成待打分: Rollout completed and pending scoring.</description></item>
        /// <item><description>已打分待采样: Scored and pending sampling.</description></item>
        /// <item><description>已采样待训练: Sampled and pending training.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>生成中</para>
        /// </summary>
        [NameInMap("Milestone")]
        [Validation(Required=false)]
        public string Milestone { get; set; }

        /// <summary>
        /// <para>The number of completed generation rounds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NTurns")]
        [Validation(Required=false)]
        public int? NTurns { get; set; }

        /// <summary>
        /// <para>The UID of the sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>321fa56f-e1e5-4eb3-8047-db7a230c9a75</para>
        /// </summary>
        [NameInMap("PromptUid")]
        [Validation(Required=false)]
        public string PromptUid { get; set; }

        /// <summary>
        /// <para>The ordinal number of the trajectory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SampleIndex")]
        [Validation(Required=false)]
        public string SampleIndex { get; set; }

    }

}
