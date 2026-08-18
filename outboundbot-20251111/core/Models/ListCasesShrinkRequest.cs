// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListCasesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access channel ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33606503-c22c-4547-a51c-dda5e8d87962</para>
        /// </summary>
        [NameInMap("AccessChannelId")]
        [Validation(Required=false)]
        public string AccessChannelId { get; set; }

        /// <summary>
        /// <para>The access channel type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("AccessChannelType")]
        [Validation(Required=false)]
        public string AccessChannelType { get; set; }

        /// <summary>
        /// <para>The caller number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01080862792</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>The outbound campaign ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7607dae1-91ad-47ea-ad76-3d81ac34f729</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>Specifies whether the case is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CaseCompleted")]
        [Validation(Required=false)]
        public bool? CaseCompleted { get; set; }

        /// <summary>
        /// <para>The list of case IDs.</para>
        /// </summary>
        [NameInMap("CaseIds")]
        [Validation(Required=false)]
        public string CaseIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of disposition codes.</para>
        /// </summary>
        [NameInMap("DispositionCodes")]
        [Validation(Required=false)]
        public string DispositionCodesShrink { get; set; }

        /// <summary>
        /// <para>The list of disposition reasons.</para>
        /// </summary>
        [NameInMap("DispositionReasons")]
        [Validation(Required=false)]
        public string DispositionReasonsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the version is a draft version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DraftVersion")]
        [Validation(Required=false)]
        public bool? DraftVersion { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578995079000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5fc6490-ef1e-4666-870a-07a4e586c414</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The label search condition.</para>
        /// </summary>
        [NameInMap("LabelSearch")]
        [Validation(Required=false)]
        public string LabelSearchShrink { get; set; }

        /// <summary>
        /// <para>The maximum ringing duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxRingingDuration")]
        [Validation(Required=false)]
        public long? MaxRingingDuration { get; set; }

        /// <summary>
        /// <para>The maximum talk time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxTalkTime")]
        [Validation(Required=false)]
        public long? MaxTalkTime { get; set; }

        /// <summary>
        /// <para>The maximum number of conversation turns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxTalkTurns")]
        [Validation(Required=false)]
        public long? MaxTalkTurns { get; set; }

        /// <summary>
        /// <para>The minimum ringing duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinRingingDuration")]
        [Validation(Required=false)]
        public long? MinRingingDuration { get; set; }

        /// <summary>
        /// <para>The minimum talk time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinTalkTime")]
        [Validation(Required=false)]
        public long? MinTalkTime { get; set; }

        /// <summary>
        /// <para>The minimum number of conversation turns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinTalkTurns")]
        [Validation(Required=false)]
        public long? MinTalkTurns { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18512345678</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c5d8c0-c0f1-48a7-be2b-dc46006d888a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578965079000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The list of case states.</para>
        /// </summary>
        [NameInMap("States")]
        [Validation(Required=false)]
        public string StatesShrink { get; set; }

    }

}
