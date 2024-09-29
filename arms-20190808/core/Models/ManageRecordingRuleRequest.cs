// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ManageRecordingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf09705f5a82f454db0d50420b6b4e904</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87348589207</para>
        /// </summary>
        [NameInMap("QueryUserId")]
        [Validation(Required=false)]
        public string QueryUserId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The recording rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>groups:\n- interval: 60s\n  name: auto_analyzer_recording_rule_60s\n  rules:\n  - expr: sum(node_cpu_seconds_total)\n    record: sum:node_cpu_seconds_total:recording_rule_hash_f341458c0f7d\n</para>
        /// </summary>
        [NameInMap("RuleYaml")]
        [Validation(Required=false)]
        public string RuleYaml { get; set; }

    }

}
