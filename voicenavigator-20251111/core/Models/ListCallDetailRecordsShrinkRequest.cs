// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListCallDetailRecordsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>33606503-c22c-4547-a51c-dda5e8d87962</para>
        /// </summary>
        [NameInMap("AccessChannelId")]
        [Validation(Required=false)]
        public string AccessChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PSTN</para>
        /// </summary>
        [NameInMap("AccessChannelType")]
        [Validation(Required=false)]
        public string AccessChannelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18104560087</para>
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>09876543210,</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("DispositionCodes")]
        [Validation(Required=false)]
        public string DispositionCodesShrink { get; set; }

        [NameInMap("DispositionReasons")]
        [Validation(Required=false)]
        public string DispositionReasonsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DraftVersion")]
        [Validation(Required=false)]
        public bool? DraftVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1582103299434</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IssueResolved")]
        [Validation(Required=false)]
        public bool? IssueResolved { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxTalkTurns")]
        [Validation(Required=false)]
        public int? MaxTalkTurns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinTalkTurns")]
        [Validation(Required=false)]
        public int? MinTalkTurns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64241e64-190c-45d1-af66-06f51c07b090</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("SessionIds")]
        [Validation(Required=false)]
        public string SessionIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1774858849987</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
