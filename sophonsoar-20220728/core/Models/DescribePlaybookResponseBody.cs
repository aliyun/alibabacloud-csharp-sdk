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
            /// <para>The number of times the playbook failed to run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailExeNum")]
            [Validation(Required=false)]
            public int? FailExeNum { get; set; }

            /// <summary>
            /// <para>The time when the playbook was created. This is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665288858000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the playbook was last modified. This is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677482519000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The input parameter configuration of the playbook. The value is a JSONArray string.</para>
            /// <remarks>
            /// <para>For more information about the format, see <a href="~~DescribePlaybookInputOutput~~">DescribePlaybookInputOutput</a>.</para>
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
            /// <para>The last time when the playbook was run. This is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665288858000</para>
            /// </summary>
            [NameInMap("LastExeTime")]
            [Validation(Required=false)]
            public long? LastExeTime { get; set; }

            /// <summary>
            /// <para>A flag that indicates whether the playbook is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The playbook is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The playbook is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnlineActive")]
            [Validation(Required=false)]
            public bool? OnlineActive { get; set; }

            /// <summary>
            /// <para>The MD5 value of the latest published version of the playbook.</para>
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
            /// <item><description><para><b>preset</b>: predefined playbook.</para>
            /// </description></item>
            /// <item><description><para><b>user</b>: custom playbook.</para>
            /// </description></item>
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
            /// <para>The number of times the playbook was successfully run.</para>
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
            /// <para>The configuration format of the playbook.</para>
            /// <list type="bullet">
            /// <item><description><para><b>xml</b>: XML format.</para>
            /// </description></item>
            /// <item><description><para><b>x6</b>: JSON format.</para>
            /// </description></item>
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
        /// <para>The request ID. This is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2989BC59-E9F0-5C83-B453-B368857649C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
