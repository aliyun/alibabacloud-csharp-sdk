// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetExecutionTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\n \&quot;FormatVersion\&quot;: \&quot;OOS-2019-06-01\&quot;,\n \&quot;Parameters\&quot;: {\n \&quot;Status\&quot;: {\n \&quot;Type\&quot;: \&quot;String\&quot;,\n \&quot;Description\&quot;: \&quot;(Required) The ID of the ECS instance.\&quot;\n }\n },\n \&quot;Tasks\&quot;: [\n {\n \&quot;Name\&quot;: \&quot;bar\&quot;,\n \&quot;Properties\&quot;: {\n \&quot;Parameters\&quot;: {\n \&quot;Status\&quot;: \&quot;{{ Status }}\&quot;\n },\n \&quot;API\&quot;: \&quot;DescribeInstances\&quot;,\n \&quot;Service\&quot;: \&quot;Ecs\&quot;\n },\n \&quot;Action\&quot;: \&quot;acs::ExecuteAPI\&quot;,\n \&quot;Outputs\&quot;: {\n \&quot;InstanceIds\&quot;, {\n \&quot;ValueSelector\&quot;: \&quot;.Instances.Instance[].InstanceId\&quot;,\n \&quot;Type\&quot;: \&quot;List\&quot;\n }\n }\n }\n ],\n \&quot;Outputs\&quot;: {\n \&quot;InstanceIds\&quot;: {\n \&quot;Value\&quot;: \&quot; {{ bar.InstanceIds }} \&quot;,\n \&quot;Type\&quot;: \&quot;List\&quot;\n }\n }\n}\n&quot;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A60-EBE7-47CA-9757-12C1D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metadata of the template.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public GetExecutionTemplateResponseBodyTemplate Template { get; set; }
        public class GetExecutionTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The creator of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(13090000)</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Get status of instances</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The SHA-256 value of the template content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4bc7d7a21b3e003434b9c223f6e6d2578b5ebfeb5be28c1fcf8a8a1b11907bb4</para>
            /// </summary>
            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            /// <summary>
            /// <para>The share type of the template. The share type of a user-created template is <b>Private</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The tag keys and values. The number of key-value pairs ranges from 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;:&quot;k2&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The format of the template. The system automatically determines whether the format is JSON or YAML.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSON</para>
            /// </summary>
            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-94753d4d828d38</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyTemplate</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The version of the template. The name of the version consists of the letter v and a number. The number starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The user who last updated the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(13090000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

    }

}
