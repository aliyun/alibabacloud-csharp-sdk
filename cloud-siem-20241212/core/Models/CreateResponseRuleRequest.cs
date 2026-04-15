// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateResponseRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;actionType&quot;:&quot;doPlaybook&quot;,&quot;playbookName&quot;:&quot;block waf IP&quot;,&quot;playbookUuid&quot;:&quot;system_aliyun_waf_whole_process_book&quot;,&quot;disposeParam&quot;:{&quot;period&quot;:&quot;7d&quot;}}]</para>
        /// </summary>
        [NameInMap("ResponseActionConfig")]
        [Validation(Required=false)]
        public string ResponseActionConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>doPlaybook</para>
        /// </summary>
        [NameInMap("ResponseActionType")]
        [Validation(Required=false)]
        public string ResponseActionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;left&quot;:{&quot;value&quot;:&quot;threat_level&quot;},&quot;operator&quot;:&quot;equals&quot;,&quot;right&quot;:{&quot;value&quot;:&quot;suspicious&quot;}}]</para>
        /// </summary>
        [NameInMap("ResponseExecutionCondition")]
        [Validation(Required=false)]
        public string ResponseExecutionCondition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Send Notification When Generating Urgent Incident</para>
        /// </summary>
        [NameInMap("ResponseRuleName")]
        [Validation(Required=false)]
        public string ResponseRuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResponseRulePriority")]
        [Validation(Required=false)]
        public string ResponseRulePriority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("ResponseTriggerType")]
        [Validation(Required=false)]
        public string ResponseTriggerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
