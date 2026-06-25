// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeSystemPropertyTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token used to start the next query. An empty value indicates that all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kU****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C5CEF0A-D6E1-58D3-8750-67DB4F82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of property template objects.</para>
        /// </summary>
        [NameInMap("SystemPropertyTemplateModel")]
        [Validation(Required=false)]
        public List<DescribeSystemPropertyTemplatesResponseBodySystemPropertyTemplateModel> SystemPropertyTemplateModel { get; set; }
        public class DescribeSystemPropertyTemplatesResponseBodySystemPropertyTemplateModel : TeaModel {
            /// <summary>
            /// <para>Indicates whether preset system properties can be automatically generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAuto")]
            [Validation(Required=false)]
            public bool? EnableAuto { get; set; }

            /// <summary>
            /// <para>The URL path of the property template file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://filepath****.com">https://filepath****.com</a></para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The template status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>init</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The system property template information.</para>
            /// </summary>
            [NameInMap("SystemPropertyInfo")]
            [Validation(Required=false)]
            public DescribeSystemPropertyTemplatesResponseBodySystemPropertyTemplateModelSystemPropertyInfo SystemPropertyInfo { get; set; }
            public class DescribeSystemPropertyTemplatesResponseBodySystemPropertyTemplateModelSystemPropertyInfo : TeaModel {
                /// <summary>
                /// <para>The custom property information.</para>
                /// </summary>
                [NameInMap("CustomPropertyInfos")]
                [Validation(Required=false)]
                public List<DescribeSystemPropertyTemplatesResponseBodySystemPropertyTemplateModelSystemPropertyInfoCustomPropertyInfos> CustomPropertyInfos { get; set; }
                public class DescribeSystemPropertyTemplatesResponseBodySystemPropertyTemplateModelSystemPropertyInfoCustomPropertyInfos : TeaModel {
                    /// <summary>
                    /// <para>The property name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>propKey</para>
                    /// </summary>
                    [NameInMap("PropertyName")]
                    [Validation(Required=false)]
                    public string PropertyName { get; set; }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>propValue</para>
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not yet available for use.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RoProductDevice")]
                [Validation(Required=false)]
                public string RoProductDevice { get; set; }

            }

            /// <summary>
            /// <para>The property template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-0caoenwutkkx****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template 1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
