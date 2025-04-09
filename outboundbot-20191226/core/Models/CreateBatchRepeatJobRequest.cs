// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateBatchRepeatJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded,NoInteraction,Failed,Cancelled</para>
        /// </summary>
        [NameInMap("FilterStatus")]
        [Validation(Required=false)]
        public string FilterStatus { get; set; }

        [NameInMap("FlashSmsExtras")]
        [Validation(Required=false)]
        public string FlashSmsExtras { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2bfa5ae4-7185-4227-a3b8-328f26f11be1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;emptyNumberIgnore\&quot;:false,\&quot;inArrearsIgnore\&quot;:false,\&quot;outOfServiceIgnore\&quot;:false}</para>
        /// </summary>
        [NameInMap("RecallStrategyJson")]
        [Validation(Required=false)]
        public string RecallStrategyJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RingingDuration")]
        [Validation(Required=false)]
        public long? RingingDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0fe7f71c-8771-42ef-9bb1-19aa16ae7120</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4f8a3d3-2e94-4bd4-aef8-e35f663d4847</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;maxAttemptsPerDay\&quot;:1,\&quot;minAttemptInterval\&quot;:1,\&quot;routingStrategy\&quot;:\&quot;LocalFirst\&quot;}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
