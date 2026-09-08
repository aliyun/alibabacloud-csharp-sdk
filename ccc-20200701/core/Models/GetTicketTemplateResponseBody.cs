// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetTicketTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTicketTemplateResponseBodyData Data { get; set; }
        public class GetTicketTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Ticket category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43c2671b-****-4223-86d0-6bd187905cc8</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>Template editor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editor-xxx@ccc-test</para>
            /// </summary>
            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试模板。</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Workflow information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;id\&quot;:\&quot;TICKET_START\&quot;,\&quot;name\&quot;:\&quot;开始\&quot;,\&quot;nodeIndex\&quot;:0,\&quot;properties\&quot;:{\&quot;position\&quot;:{\&quot;x\&quot;:250,\&quot;y\&quot;:200}},\&quot;type\&quot;:\&quot;TICKET_START\&quot;,\&quot;events\&quot;:[{\&quot;edgeId\&quot;:\&quot;8bd07339\&quot;,\&quot;sourceAnchor\&quot;:0,\&quot;next\&quot;:\&quot;APPROVAL__JNBSSREc\&quot;,\&quot;targetAnchor\&quot;:0}]},{\&quot;id\&quot;:\&quot;TICKET_FINISH\&quot;,\&quot;name\&quot;:\&quot;结束\&quot;,\&quot;nodeIndex\&quot;:9999,\&quot;properties\&quot;:{\&quot;position\&quot;:{\&quot;x\&quot;:767,\&quot;y\&quot;:206}},\&quot;type\&quot;:\&quot;TICKET_FINISH\&quot;,\&quot;events\&quot;:[]},{\&quot;id\&quot;:\&quot;APPROVAL__JNBSSREc\&quot;,\&quot;name\&quot;:\&quot;流程节点\&quot;,\&quot;nodeIndex\&quot;:1,\&quot;properties\&quot;:{\&quot;skillGroupId\&quot;:\&quot;chat001@cccV2-kmz\&quot;,\&quot;position\&quot;:{\&quot;x\&quot;:537,\&quot;y\&quot;:164.5}},\&quot;type\&quot;:\&quot;APPROVAL\&quot;,\&quot;events\&quot;:[{\&quot;edgeId\&quot;:\&quot;74031613\&quot;,\&quot;sourceAnchor\&quot;:1,\&quot;next\&quot;:\&quot;TICKET_FINISH\&quot;,\&quot;targetAnchor\&quot;:0}]}]</para>
            /// </summary>
            [NameInMap("ProcessDefinition")]
            [Validation(Required=false)]
            public string ProcessDefinition { get; set; }

            /// <summary>
            /// <para>Status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4ca2e2-c8d19b82c-d7ce393ac8197d3ab</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>List of template fields.</para>
            /// </summary>
            [NameInMap("TicketFields")]
            [Validation(Required=false)]
            public List<GetTicketTemplateResponseBodyDataTicketFields> TicketFields { get; set; }
            public class GetTicketTemplateResponseBodyDataTicketFields : TeaModel {
                /// <summary>
                /// <para>Whether the field is an array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                /// <summary>
                /// <para>Extension attributes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717664210000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>Creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>creator@cccV2-kmz</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>Data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>Description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>姓名描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Whether the field is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>Display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>姓名</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>Display order in lists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                /// <summary>
                /// <para>Editor type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>textbox</para>
                /// </summary>
                [NameInMap("EditorType")]
                [Validation(Required=false)]
                public string EditorType { get; set; }

                /// <summary>
                /// <para>Maximum length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public int? MaxLength { get; set; }

                /// <summary>
                /// <para>Numeric maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Maximum")]
                [Validation(Required=false)]
                public double? Maximum { get; set; }

                /// <summary>
                /// <para>Minimum length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public int? MinLength { get; set; }

                /// <summary>
                /// <para>Numeric minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Minimum")]
                [Validation(Required=false)]
                public double? Minimum { get; set; }

                /// <summary>
                /// <para>Name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Regular expression validation rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>Error message for regular expression validation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>不是有效的email地址</para>
                /// </summary>
                [NameInMap("PatternErrorMessage")]
                [Validation(Required=false)]
                public string PatternErrorMessage { get; set; }

                /// <summary>
                /// <para>Whether the field is read-only.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>Whether the field is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>Whether the field is a system field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("System")]
                [Validation(Required=false)]
                public bool? System { get; set; }

                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717664210000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            /// <summary>
            /// <para>Last modified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717664210000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>List of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF268B34-09C2-43FD-BAC4-5D31EA633111</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
