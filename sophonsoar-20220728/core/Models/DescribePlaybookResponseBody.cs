// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the playbook.</para>
        /// </summary>
        [NameInMap("Playbook")]
        [Validation(Required=false)]
        public DescribePlaybookResponseBodyPlaybook Playbook { get; set; }
        public class DescribePlaybookResponseBodyPlaybook : TeaModel {
            /// <summary>
            /// <para>The description of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo playbook</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The number of times that the playbook failed to be run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailExeNum")]
            [Validation(Required=false)]
            public int? FailExeNum { get; set; }

            /// <summary>
            /// <para>The creation time of the playbook. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665288858000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time of the playbook. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677482519000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The input parameter configuration of the playbook. The value is a JSON array.</para>
            /// <remarks>
            /// <para> For more information, see <a href="~~DescribePlaybookInputOutput~~">DescribePlaybookInputOutput</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;typeName&quot;: &quot;String&quot;,
            ///         &quot;dataClass&quot;: &quot;normal&quot;,
            ///         &quot;dataType&quot;: &quot;String&quot;,
            ///         &quot;description&quot;: &quot;period&quot;,
            ///         &quot;example&quot;: &quot;&quot;,
            ///         &quot;name&quot;: &quot;period&quot;,
            ///         &quot;required&quot;: false
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            /// <summary>
            /// <para>The time when the playbook was last run. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665288858000</para>
            /// </summary>
            [NameInMap("LastExeTime")]
            [Validation(Required=false)]
            public long? LastExeTime { get; set; }

            /// <summary>
            /// <para>The status of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnlineActive")]
            [Validation(Required=false)]
            public bool? OnlineActive { get; set; }

            /// <summary>
            /// <para>The MD5 hash value in the latest published version of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdfsdfe232-e2b2-44fd-b2cc-xxxxx</para>
            /// </summary>
            [NameInMap("OnlineReleaseTaskflowMd5")]
            [Validation(Required=false)]
            public string OnlineReleaseTaskflowMd5 { get; set; }

            /// <summary>
            /// <para>The type of the playbook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>preset</b>: predefined playbook</description></item>
            /// <item><description><b>user</b>: custom playbook</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            /// <summary>
            /// <para>The UUID of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8db257d3-e2b2-44fd-b2cc-xxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>The number of times that the playbook was successfully run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccessExeNum")]
            [Validation(Required=false)]
            public int? SuccessExeNum { get; set; }

            /// <summary>
            /// <para>The XML configuration of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <?xml version="1.0" encoding="UTF-8"?><para>&lt;bpmn:definitions xmlns:xsi=&quot;<a href="http://www.w3.org/2001/XMLSchema-instance">http://www.w3.org/2001/XMLSchema-instance</a>&quot; xmlns:bpmn=&quot;<a href="http://www.omg.org/spec/BPMN/20100524/MODEL">http://www.omg.org/spec/BPMN/20100524/MODEL</a>&quot; xmlns:bpmndi=&quot;<a href="http://www.omg.org/spec/BPMN/20100524/DI">http://www.omg.org/spec/BPMN/20100524/DI</a>&quot; xmlns:dc=&quot;<a href="http://www.omg.org/spec/DD/20100524/DC">http://www.omg.org/spec/DD/20100524/DC</a>&quot; targetNamespace=&quot;<a href="http://bpmn.io/schema/bpmn">http://bpmn.io/schema/bpmn</a>&quot; id=&quot;Definitions_1&quot;&gt;&lt;bpmn:process id=&quot;Process_1&quot; isExecutable=&quot;false&quot;&gt;&lt;bpmn:startEvent id=&quot;StartEvent_1&quot;/&gt;</bpmn:process>&lt;bpmndi:BPMNDiagram id=&quot;BPMNDiagram_1&quot;&gt;&lt;bpmndi:BPMNPlane id=&quot;BPMNPlane_1&quot; bpmnElement=&quot;Process_1&quot;&gt;&lt;bpmndi:BPMNShape id=&quot;_BPMNShape_StartEvent_2&quot; bpmnElement=&quot;StartEvent_1&quot;&gt;&lt;dc:Bounds height=&quot;36.0&quot; width=&quot;36.0&quot; x=&quot;173.0&quot; y=&quot;102.0&quot;/&gt;</bpmndi:BPMNShape></bpmndi:BPMNPlane></bpmndi:BPMNDiagram></bpmn:definitions></para>
            /// </summary>
            [NameInMap("Taskflow")]
            [Validation(Required=false)]
            public string Taskflow { get; set; }

            /// <summary>
            /// <para>The playbook configuration type.</para>
            /// <list type="bullet">
            /// <item><description><b>xml</b>: XML format.</description></item>
            /// <item><description><b>x6</b>: JSON format.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>xml</para>
            /// </summary>
            [NameInMap("TaskflowType")]
            [Validation(Required=false)]
            public string TaskflowType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2989BC59-E9F0-5C83-B453-B368857649C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
