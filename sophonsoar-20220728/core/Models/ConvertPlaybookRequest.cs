// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ConvertPlaybookRequest : TeaModel {
        /// <summary>
        /// <para>Language type for request and response messages. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>User ID for the administrator to switch to another member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13760*****718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>View type. Values:</para>
        /// <list type="bullet">
        /// <item><description>0: Current Alibaba Cloud account view.</description></item>
        /// <item><description>1: View for all accounts under the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>XML configuration information for playbook orchestration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <?xml version=\\"1.0\\" encoding=\\"UTF-8\\"?>
        /// <para>&lt;bpmn:definitions xmlns:xsi=\&quot;<a href="http://www.w3.org/2001/XMLSchema-instance%5C%5C">http://www.w3.org/2001/XMLSchema-instance\\</a>&quot; xmlns:bpmn=\&quot;<a href="http://www.omg.org/spec/BPMN/20100524/MODEL%5C%5C">http://www.omg.org/spec/BPMN/20100524/MODEL\\</a>&quot; xmlns:bpmndi=\&quot;<a href="http://www.omg.org/spec/BPMN/20100524/DI%5C%5C">http://www.omg.org/spec/BPMN/20100524/DI\\</a>&quot; xmlns:dc=\&quot;<a href="http://www.omg.org/spec/DD/20100524/DC%5C%5C">http://www.omg.org/spec/DD/20100524/DC\\</a>&quot; id=\&quot;Definitions_1\&quot; targetNamespace=\&quot;<a href="http://bpmn.io/schema/bpmn%5C%5C%22%3E">http://bpmn.io/schema/bpmn\\&quot;&gt;</a>
        ///   &lt;bpmn:process id=\&quot;Process_1\&quot; isExecutable=\&quot;false\&quot;&gt;
        ///     &lt;bpmn:startEvent id=\&quot;StartEvent_1\&quot; /&gt;
        ///   </bpmn:process>
        ///   &lt;bpmndi:BPMNDiagram id=\&quot;BPMNDiagram_1\&quot;&gt;
        ///      &lt;bpmndi:BPMNPlane id=\&quot;BPMNPlane_1\&quot; bpmnElement=\&quot;Process_1\&quot;&gt;
        ///            &lt;bpmndi:BPMNShape id=\&quot;_BPMNShape_StartEvent_2\&quot; bpmnElement=\&quot;StartEvent_1\&quot;&gt;
        ///                    &lt;dc:Bounds x=\&quot;173\&quot; y=\&quot;102\&quot; width=\&quot;36\&quot; height=\&quot;36\&quot; /&gt;
        ///             </bpmndi:BPMNShape>
        ///      </bpmndi:BPMNPlane>
        ///   </bpmndi:BPMNDiagram>
        /// </bpmn:definitions></para>
        /// </summary>
        [NameInMap("Taskflow")]
        [Validation(Required=false)]
        public string Taskflow { get; set; }

    }

}
