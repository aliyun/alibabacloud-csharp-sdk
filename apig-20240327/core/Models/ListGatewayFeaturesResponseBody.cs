// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewayFeaturesResponseBodyData Data { get; set; }
        public class ListGatewayFeaturesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of parameter configurations.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayFeaturesResponseBodyDataItems> Items { get; set; }
            public class ListGatewayFeaturesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The parameter definition.</para>
                /// </summary>
                [NameInMap("definition")]
                [Validation(Required=false)]
                public ListGatewayFeaturesResponseBodyDataItemsDefinition Definition { get; set; }
                public class ListGatewayFeaturesResponseBodyDataItemsDefinition : TeaModel {
                    /// <summary>
                    /// <para>The default value of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;true&quot;</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>The parameter description.</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The display name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EnableGzip</para>
                    /// </summary>
                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The parameter group to which the parameter belongs. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Telemetry: an observability parameter</description></item>
                    /// <item><description>Engine: an engine parameter</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Engine</para>
                    /// </summary>
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    /// <summary>
                    /// <para>The input type of the parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Trigger</description></item>
                    /// <item><description>Input</description></item>
                    /// <item><description>SingleSelect</description></item>
                    /// <item><description>MultiSelect</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Trigger</para>
                    /// </summary>
                    [NameInMap("inputType")]
                    [Validation(Required=false)]
                    public string InputType { get; set; }

                    /// <summary>
                    /// <para>The maximum length of the value. This parameter is valid when the value type is string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("maxLength")]
                    [Validation(Required=false)]
                    public int? MaxLength { get; set; }

                    /// <summary>
                    /// <para>The maximum value of the parameter. This parameter is valid when the value type is int32, int64, or float.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65535</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public string MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum length of the value. This parameter is valid when the value type is string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("minLength")]
                    [Validation(Required=false)]
                    public int? MinLength { get; set; }

                    /// <summary>
                    /// <para>The minimum value of the parameter. This parameter is valid when the value type is int32, int64, or float.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public string MinValue { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enable-gzip</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the parameter is read-only.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("readOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>The regular expression that the parameter value must fulfill. This parameter is valid when the value type is string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[a-z].*</para>
                    /// </summary>
                    [NameInMap("regex")]
                    [Validation(Required=false)]
                    public string Regex { get; set; }

                    /// <summary>
                    /// <para>The list of options supported by the parameter value.</para>
                    /// </summary>
                    [NameInMap("valueOptions")]
                    [Validation(Required=false)]
                    public List<ListGatewayFeaturesResponseBodyDataItemsDefinitionValueOptions> ValueOptions { get; set; }
                    public class ListGatewayFeaturesResponseBodyDataItemsDefinitionValueOptions : TeaModel {
                        /// <summary>
                        /// <para>The key to pass the parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KEEP_UNCHANGED</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The display value.</para>
                        /// </summary>
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <para>The value type of the parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>bool: boolean</description></item>
                    /// <item><description>string</description></item>
                    /// <item><description>int32: integer</description></item>
                    /// <item><description>int64: long integer</description></item>
                    /// <item><description>json</description></item>
                    /// <item><description>array: JSON array</description></item>
                    /// <item><description>float: floating point</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bool</para>
                    /// </summary>
                    [NameInMap("valueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                    /// <summary>
                    /// <para>The value unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>byte</para>
                    /// </summary>
                    [NameInMap("valueUnit")]
                    [Validation(Required=false)]
                    public string ValueUnit { get; set; }

                }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;true&quot;</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
