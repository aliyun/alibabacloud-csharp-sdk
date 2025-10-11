// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationParametersResponseBody : TeaModel {
        [NameInMap("ParameterTemplates")]
        [Validation(Required=false)]
        public DescribeApplicationParametersResponseBodyParameterTemplates ParameterTemplates { get; set; }
        public class DescribeApplicationParametersResponseBodyParameterTemplates : TeaModel {
            [NameInMap("ComponentParameterTemplates")]
            [Validation(Required=false)]
            public List<DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplates> ComponentParameterTemplates { get; set; }
            public class DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplates : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pac-**************</para>
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>supabase</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplatesParameters> Parameters { get; set; }
                public class DescribeApplicationParametersResponseBodyParameterTemplatesComponentParameterTemplatesParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public string Default { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The name of the parameter</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NeedRestart")]
                    [Validation(Required=false)]
                    public bool? NeedRestart { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>^[a-zA-Z0-9]{1,20}$</para>
                    /// </summary>
                    [NameInMap("Pattern")]
                    [Validation(Required=false)]
                    public string Pattern { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeApplicationParametersResponseBodyParameters Parameters { get; set; }
        public class DescribeApplicationParametersResponseBodyParameters : TeaModel {
            [NameInMap("ComponentParameters")]
            [Validation(Required=false)]
            public List<DescribeApplicationParametersResponseBodyParametersComponentParameters> ComponentParameters { get; set; }
            public class DescribeApplicationParametersResponseBodyParametersComponentParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pac-**************</para>
                /// </summary>
                [NameInMap("ComponentId")]
                [Validation(Required=false)]
                public string ComponentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>supabase</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<DescribeApplicationParametersResponseBodyParametersComponentParametersParameters> Parameters { get; set; }
                public class DescribeApplicationParametersResponseBodyParametersComponentParametersParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default value</para>
                    /// </summary>
                    [NameInMap("Default")]
                    [Validation(Required=false)]
                    public string Default { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The name of the parameter</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NeedRestart")]
                    [Validation(Required=false)]
                    public bool? NeedRestart { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>^[a-zA-Z0-9]{1,20}$</para>
                    /// </summary>
                    [NameInMap("Pattern")]
                    [Validation(Required=false)]
                    public string Pattern { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Applied</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
