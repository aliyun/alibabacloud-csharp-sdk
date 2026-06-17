// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the parameter template.</para>
        /// </summary>
        [NameInMap("ParameterTemplates")]
        [Validation(Required=false)]
        public DescribeApplicationParametersResponseBodyParameterTemplates ParameterTemplates { get; set; }
        public class DescribeApplicationParametersResponseBodyParameterTemplates : TeaModel {
            /// <summary>
            /// <para>A list of subcomponents that contain lists of parameter template details.</para>
            /// </summary>
            [NameInMap("ComponentParameterTemplates")]
            [Validation(Required=false)]
            public List<DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplates> ComponentParameterTemplates { get; set; }
            public class DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplates : TeaModel {
                /// <summary>
                /// <para>The subcomponent ID or application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pac-**************</para>
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// <para>The type of the subcomponent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>supabase</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// <para>A list of parameter template details.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplatesParameters> Parameters { get; set; }
                public class DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplatesParameters : TeaModel {
                    /// <summary>
                    /// <para>The default value of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public string Default { get; set; }

                    /// <summary>
                    /// <para>The parameter description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The name of the parameter</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the application needs to be restarted after you modify the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NeedRestart")]
                    [Validation(Required=false)]
                    public bool? NeedRestart { get; set; }

                    /// <summary>
                    /// <para>The regular expression for the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>^[a-zA-Z0-9]{1,20}$</para>
                    /// </summary>
                    [NameInMap("Pattern")]
                    [Validation(Required=false)]
                    public string Pattern { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the parameter is read-only.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>The parameter type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The parameter details.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeApplicationParametersResponseBodyParameters Parameters { get; set; }
        public class DescribeApplicationParametersResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>A list of subcomponents that contain lists of parameter details.</para>
            /// </summary>
            [NameInMap("ComponentParameters")]
            [Validation(Required=false)]
            public List<DescribeApplicationParametersResponseBodyParametersComponentParameters> ComponentParameters { get; set; }
            public class DescribeApplicationParametersResponseBodyParametersComponentParameters : TeaModel {
                /// <summary>
                /// <para>The subcomponent ID or application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pac-**************</para>
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// <para>The type of the subcomponent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>supabase</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// <para>A list of parameter details.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<DescribeApplicationParametersResponseBodyParametersComponentParametersParameters> Parameters { get; set; }
                public class DescribeApplicationParametersResponseBodyParametersComponentParametersParameters : TeaModel {
                    /// <summary>
                    /// <para>The default value of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default value</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public string Default { get; set; }

                    /// <summary>
                    /// <para>The parameter description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The name of the parameter</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the application needs to be restarted after you modify the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NeedRestart")]
                    [Validation(Required=false)]
                    public bool? NeedRestart { get; set; }

                    /// <summary>
                    /// <para>The regular expression for the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>^[a-zA-Z0-9]{1,20}$</para>
                    /// </summary>
                    [NameInMap("Pattern")]
                    [Validation(Required=false)]
                    public string Pattern { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the parameter is read-only.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>The status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Applied</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The parameter type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The current value of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
