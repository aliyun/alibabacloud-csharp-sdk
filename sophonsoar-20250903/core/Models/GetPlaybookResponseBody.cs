// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class GetPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>Configuration information of the playbook.</para>
        /// </summary>
        [NameInMap("Playbook")]
        [Validation(Required=false)]
        public GetPlaybookResponseBodyPlaybook Playbook { get; set; }
        public class GetPlaybookResponseBodyPlaybook : TeaModel {
            /// <summary>
            /// <para>Creation time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731378251000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Description of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf ip blocked</para>
            /// </summary>
            [NameInMap("PlaybookDescription")]
            [Validation(Required=false)]
            public string PlaybookDescription { get; set; }

            /// <summary>
            /// <para>Extended information of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;opCode&quot;:1}</para>
            /// </summary>
            [NameInMap("PlaybookExtension")]
            [Validation(Required=false)]
            public string PlaybookExtension { get; set; }

            /// <summary>
            /// <para>List of playbook input parameter configurations.</para>
            /// </summary>
            [NameInMap("PlaybookInputConfigs")]
            [Validation(Required=false)]
            public List<FieldInputConfig> PlaybookInputConfigs { get; set; }

            /// <summary>
            /// <para>Name of the playbook, without special characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waftest</para>
            /// </summary>
            [NameInMap("PlaybookName")]
            [Validation(Required=false)]
            public string PlaybookName { get; set; }

            /// <summary>
            /// <para>List of playbook output parameter configurations.</para>
            /// </summary>
            [NameInMap("PlaybookOutputConfigs")]
            [Validation(Required=false)]
            public List<FieldOutputConfig> PlaybookOutputConfigs { get; set; }

            /// <summary>
            /// <para>Parameter type of the playbook, with the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>template-ip</b>: IP entity.</description></item>
            /// <item><description><b>template-file</b>: File entity.</description></item>
            /// <item><description><b>template-process</b>: Process entity.</description></item>
            /// <item><description><b>template-host</b>: Host entity.</description></item>
            /// <item><description><b>template-domain</b>: Domain entity.</description></item>
            /// <item><description><b>template-container</b>: Container entity.</description></item>
            /// <item><description><b>template-incident</b>: Security incident.</description></item>
            /// <item><description><b>template-alert</b>: Security alert.</description></item>
            /// <item><description><b>custom</b>: Custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>template-ip</para>
            /// </summary>
            [NameInMap("PlaybookParamType")]
            [Validation(Required=false)]
            public string PlaybookParamType { get; set; }

            /// <summary>
            /// <para>Input example of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ip&quot;:&quot;1.<em>.</em>.1&quot;}</para>
            /// </summary>
            [NameInMap("PlaybookParamsExample")]
            [Validation(Required=false)]
            public string PlaybookParamsExample { get; set; }

            /// <summary>
            /// <para>Publication status of the playbook, with the following values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unpublished.</description></item>
            /// <item><description><b>1</b>: Published.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PlaybookStatus")]
            [Validation(Required=false)]
            public int? PlaybookStatus { get; set; }

            /// <summary>
            /// <para>Workflow of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("PlaybookTaskFlow")]
            [Validation(Required=false)]
            public string PlaybookTaskFlow { get; set; }

            /// <summary>
            /// <para>UUID of the playbook workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8ea81047-<b><b>-4481-</b></b>-fcd8557bf242</para>
            /// </summary>
            [NameInMap("PlaybookTaskFlowUuid")]
            [Validation(Required=false)]
            public string PlaybookTaskFlowUuid { get; set; }

            /// <summary>
            /// <para>Type of the playbook, with values as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>preset</b>: Predefined playbook.</description></item>
            /// <item><description><b>user</b>: Custom playbook.</description></item>
            /// <item><description><b>component</b>: Security response component.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("PlaybookType")]
            [Validation(Required=false)]
            public string PlaybookType { get; set; }

            /// <summary>
            /// <para>UUID of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8db257d3-e2b2-44fd-b2cc-xxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>Version number of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36c9dcd6-<b><b>-4262-</b></b>-d508464ebd21</para>
            /// </summary>
            [NameInMap("PlaybookVersion")]
            [Validation(Required=false)]
            public string PlaybookVersion { get; set; }

            /// <summary>
            /// <para>Update time (in milliseconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731378251000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request, a unique identifier generated by Alibaba Cloud for the request, which can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFEFB76D-DD0E-5529-BD57-0DAC10B9B30F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
