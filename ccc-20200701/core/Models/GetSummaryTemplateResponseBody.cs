// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetSummaryTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSummaryTemplateResponseBodyData Data { get; set; }
        public class GetSummaryTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the summary category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8939-4223-86d0-6bd187905cc8</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The template editor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editor-xxx@ccc-test</para>
            /// </summary>
            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of template fields.</para>
            /// </summary>
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<GetSummaryTemplateResponseBodyDataPropertyList> PropertyList { get; set; }
            public class GetSummaryTemplateResponseBodyDataPropertyList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the field is an array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                /// <summary>
                /// <para>The extended attributes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717664210000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cretor-xxx@ccc-test</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The field description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description-xxxx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DisplayName-A</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The display order in the list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public int? DisplayOrder { get; set; }

                /// <summary>
                /// <para>The editor type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>textbox</para>
                /// </summary>
                [NameInMap("EditorType")]
                [Validation(Required=false)]
                public string EditorType { get; set; }

                /// <summary>
                /// <para>The maximum length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public int? MaxLength { get; set; }

                /// <summary>
                /// <para>The maximum numeric value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Maximum")]
                [Validation(Required=false)]
                public double? Maximum { get; set; }

                /// <summary>
                /// <para>The minimum length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public int? MinLength { get; set; }

                /// <summary>
                /// <para>The minimum numeric value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Minimum")]
                [Validation(Required=false)]
                public double? Minimum { get; set; }

                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name-A</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The regular expression validation rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^</para>
                /// </summary>
                [NameInMap("Pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

                /// <summary>
                /// <para>The error message for regular expression validation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Not a valid email address</para>
                /// </summary>
                [NameInMap("PatternErrorMessage")]
                [Validation(Required=false)]
                public string PatternErrorMessage { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is read-only.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is a system field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("System")]
                [Validation(Required=false)]
                public bool? System { get; set; }

                /// <summary>
                /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1717664210000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            /// <summary>
            /// <para>The status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: Enabled.</description></item>
            /// <item><description>Disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43c2671b-8939-4223-86d0-6bd187905cc8_1717664210492</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30C7D235-DDCF-4C7F-A462-5E2598252C2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
