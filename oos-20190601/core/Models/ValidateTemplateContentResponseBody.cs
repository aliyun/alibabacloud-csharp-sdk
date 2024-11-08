// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ValidateTemplateContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The outputs of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <para>The parameters of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Status&quot;: { &quot;Description&quot;: &quot;(Required) The status of the Ecs instance.&quot;, &quot;Type&quot;: &quot;String&quot; } }</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OOSServiceRole</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5EE9591-1F2D-573E-8751-7F08BBB388D4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task defined in the template.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ValidateTemplateContentResponseBodyTasks> Tasks { get; set; }
        public class ValidateTemplateContentResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The description of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(Required) The status of the Ecs instance.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>foo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The outputs of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.instanceId</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The properties of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;API&quot;: &quot;DescribeInstances&quot;,&quot;Parameters&quot;: {&quot;Status&quot;: &quot;{{ Status }}&quot;},&quot;Service&quot;: &quot;Ecs&quot;}</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>The type of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ExecuteAPI</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
