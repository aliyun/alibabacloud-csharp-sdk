// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Version.NotExist</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>The maximum duration for which a task can be executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638157479281</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionVersionResponseBodyResult Result { get; set; }
        public class GetFunctionVersionResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ctr</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The type of the feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PAAS</description></item>
            /// <item><description>SAAS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAAS</para>
            /// </summary>
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// <para>The type of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tf_checkpoint</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The configuration information.</para>
            /// </summary>
            [NameInMap("VersionConfig")]
            [Validation(Required=false)]
            public GetFunctionVersionResponseBodyResultVersionConfig VersionConfig { get; set; }
            public class GetFunctionVersionResponseBodyResultVersionConfig : TeaModel {
                /// <summary>
                /// <para>The parameters that are used to create the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[                 {                     &quot;name&quot;: &quot;params1&quot;,                     &quot;required&quot;: &quot;true&quot;,                     &quot;formItemProps&quot;: &quot;{\&quot;required\&quot;: true, \&quot;pattern?\&quot;: \&quot;/^[a-zA-Z][a-zA-Z0-9_]{0,29}$/\&quot;}&quot;,                     &quot;componentProps&quot;: &quot;{\&quot;component\&quot;: \&quot;Input\&quot;, \&quot;attributes\&quot;: {\&quot;defaultValue\&quot;: \&quot;value1\&quot;}}&quot;                 }             ]</para>
                /// </summary>
                [NameInMap("CreateParameters")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigCreateParameters> CreateParameters { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigCreateParameters : TeaModel {
                    /// <summary>
                    /// <para>The name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>params1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public string Required { get; set; }

                }

                /// <summary>
                /// <para>The dependencies of the instance.</para>
                /// </summary>
                [NameInMap("Depends")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigDepends> Depends { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigDepends : TeaModel {
                    /// <summary>
                    /// <para>The condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The dependency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Dependency")]
                    [Validation(Required=false)]
                    public string Dependency { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are used during online use of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("UsageParameters")]
                [Validation(Required=false)]
                public List<GetFunctionVersionResponseBodyResultVersionConfigUsageParameters> UsageParameters { get; set; }
                public class GetFunctionVersionResponseBodyResultVersionConfigUsageParameters : TeaModel {
                    /// <summary>
                    /// <para>The name of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public string Required { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            /// <summary>
            /// <para>The name of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The status of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
