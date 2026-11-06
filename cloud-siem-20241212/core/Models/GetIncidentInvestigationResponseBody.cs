// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetIncidentInvestigationResponseBody : TeaModel {
        /// <summary>
        /// <para>The AI investigation details of the event. This parameter is empty if no matching investigation record is found.</para>
        /// </summary>
        [NameInMap("IncidentInvestigation")]
        [Validation(Required=false)]
        public GetIncidentInvestigationResponseBodyIncidentInvestigation IncidentInvestigation { get; set; }
        public class GetIncidentInvestigationResponseBodyIncidentInvestigation : TeaModel {
            /// <summary>
            /// <para>The name of the alert that triggered this AI investigation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Webshell alert</para>
            /// </summary>
            [NameInMap("IncidentInvestigationAlertName")]
            [Validation(Required=false)]
            public string IncidentInvestigationAlertName { get; set; }

            /// <summary>
            /// <para>The judgment conclusion of the AI investigation, which corresponds to ai_judgement_conclusion in the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Existing evidence is insufficient to confirm whether the attack chain is complete. Supplement associated logs for further analysis</para>
            /// </summary>
            [NameInMap("IncidentInvestigationConclusion")]
            [Validation(Required=false)]
            public string IncidentInvestigationConclusion { get; set; }

            /// <summary>
            /// <para>The display ID of the AI investigation report. You can use it as the IncidentInvestigationDisplayId request parameter of this operation to query the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>755616bb5d63046c1e4f62ea872a****</para>
            /// </summary>
            [NameInMap("IncidentInvestigationDisplayId")]
            [Validation(Required=false)]
            public string IncidentInvestigationDisplayId { get; set; }

            /// <summary>
            /// <para>The end time of the AI investigation. The value is a UNIX timestamp in seconds. If the execution end time is not recorded, the last update time of the investigation record is used. If neither is available, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786195753</para>
            /// </summary>
            [NameInMap("IncidentInvestigationEndTime")]
            [Validation(Required=false)]
            public long? IncidentInvestigationEndTime { get; set; }

            /// <summary>
            /// <para>The unique ID of the AI investigation report. You can use it as the IncidentInvestigationId request parameter of this operation to query the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>951a6a0b-14c7-4332-ace6-bff21c******</para>
            /// </summary>
            [NameInMap("IncidentInvestigationId")]
            [Validation(Required=false)]
            public string IncidentInvestigationId { get; set; }

            /// <summary>
            /// <para>The output content of the AI investigation, which is a JSON-formatted string. It may contain fields such as investigation_report (the investigation process and evidence body, which can be in Markdown format). This parameter is empty if no corresponding output is generated. Internal fields may change with report versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;investigation_report&quot;:&quot;### Investigation results\nA suspicious file was detected, but execution evidence is missing.&quot;}</para>
            /// </summary>
            [NameInMap("IncidentInvestigationOutput")]
            [Validation(Required=false)]
            public string IncidentInvestigationOutput { get; set; }

            /// <summary>
            /// <para>The content of the AI investigation report, which is a JSON-formatted string. It may contain fields such as judgement_category (judgment category), ai_judgement_conclusion (judgment conclusion), ai_summary (summary), attack process, and attack graph. The specific content may change with report versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;judgement_category&quot;:&quot;insufficient_information_to_evaluate&quot;,&quot;ai_judgement_conclusion&quot;:&quot;Existing evidence is insufficient to confirm whether the attack chain is complete. Supplement associated logs for further analysis.&quot;,&quot;ai_summary&quot;:&quot;A suspicious file was detected. Existing evidence is insufficient to confirm whether the attack was successful.&quot;}</para>
            /// </summary>
            [NameInMap("IncidentInvestigationReport")]
            [Validation(Required=false)]
            public string IncidentInvestigationReport { get; set; }

            /// <summary>
            /// <para>The start time of the AI investigation. The value is a UNIX timestamp in seconds. If the execution start time is not recorded, the creation time of the investigation record is used. If neither is available, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1786195533</para>
            /// </summary>
            [NameInMap("IncidentInvestigationStartTime")]
            [Validation(Required=false)]
            public long? IncidentInvestigationStartTime { get; set; }

            /// <summary>
            /// <para>The judgment category of the AI investigation report, which corresponds to judgement_category in the report. It does not indicate the execution status of the asynchronous task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>real_attack: Real attack.</description></item>
            /// <item><description>blocked: Risk blocked.</description></item>
            /// <item><description>false_positive: Suspected false positive.</description></item>
            /// <item><description>insufficient_information_to_evaluate: Insufficient information to evaluate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>insufficient_information_to_evaluate</para>
            /// </summary>
            [NameInMap("IncidentInvestigationStatus")]
            [Validation(Required=false)]
            public string IncidentInvestigationStatus { get; set; }

            /// <summary>
            /// <para>The summary of the AI investigation report, which corresponds to ai_summary in the investigation results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A suspicious file was detected. Existing evidence is insufficient to confirm whether the attack was successful</para>
            /// </summary>
            [NameInMap("IncidentInvestigationSummary")]
            [Validation(Required=false)]
            public string IncidentInvestigationSummary { get; set; }

            /// <summary>
            /// <para>The globally unique UUID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9f00c254391400f6898c4d4fea******</para>
            /// </summary>
            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
