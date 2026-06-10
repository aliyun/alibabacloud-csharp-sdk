// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateBatchRepeatJobRequest : TeaModel {
        /// <summary>
        /// <para>Calling number</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>Job group description</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试3</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Job group status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded,NoInteraction,Failed,Cancelled</para>
        /// </summary>
        [NameInMap("FilterStatus")]
        [Validation(Required=false)]
        public string FilterStatus { get; set; }

        /// <summary>
        /// <para>Configuration parameters for flash SMS push, in JSON format, including configuration information for third-party flash SMS.</para>
        /// <list type="bullet">
        /// <item><description><para>Template ID: Flash SMS template ID.</para>
        /// </description></item>
        /// <item><description><para>Config ID: Flash SMS configuration ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;templateId&quot;:&quot;10471&quot;,&quot;configId&quot;:&quot;8037f524-6ff2-4dbe-bb28-f59234ea7a64&quot;}</para>
        /// </summary>
        [NameInMap("FlashSmsExtras")]
        [Validation(Required=false)]
        public string FlashSmsExtras { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2bfa5ae4-7185-4227-a3b8-328f26f11be1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Minimum concurrency</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinConcurrency")]
        [Validation(Required=false)]
        public long? MinConcurrency { get; set; }

        /// <summary>
        /// <para>Job name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Job priority</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Redial calling number list</para>
        /// </summary>
        [NameInMap("RecallCallingNumber")]
        [Validation(Required=false)]
        public List<string> RecallCallingNumber { get; set; }

        /// <summary>
        /// <para>Redial policy JSON</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;emptyNumberIgnore\&quot;:false,\&quot;inArrearsIgnore\&quot;:false,\&quot;outOfServiceIgnore\&quot;:false}</para>
        /// </summary>
        [NameInMap("RecallStrategyJson")]
        [Validation(Required=false)]
        public string RecallStrategyJson { get; set; }

        /// <summary>
        /// <para>Ringing duration</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RingingDuration")]
        [Validation(Required=false)]
        public long? RingingDuration { get; set; }

        /// <summary>
        /// <para>Script ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0fe7f71c-8771-42ef-9bb1-19aa16ae7120</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>Job group ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4f8a3d3-2e94-4bd4-aef8-e35f663d4847</para>
        /// </summary>
        [NameInMap("SourceGroupId")]
        [Validation(Required=false)]
        public string SourceGroupId { get; set; }

        /// <summary>
        /// <para>Job execution policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;maxAttemptsPerDay\&quot;:1,\&quot;minAttemptInterval\&quot;:1,\&quot;routingStrategy\&quot;:\&quot;LocalFirst\&quot;}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}
