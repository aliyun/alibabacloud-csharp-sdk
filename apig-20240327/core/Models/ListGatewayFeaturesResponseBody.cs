// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewayFeaturesResponseBodyData Data { get; set; }
        public class ListGatewayFeaturesResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayFeaturesResponseBodyDataItems> Items { get; set; }
            public class ListGatewayFeaturesResponseBodyDataItems : TeaModel {
                [NameInMap("definition")]
                [Validation(Required=false)]
                public ListGatewayFeaturesResponseBodyDataItemsDefinition Definition { get; set; }
                public class ListGatewayFeaturesResponseBodyDataItemsDefinition : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;true&quot;</para>
                    /// </summary>
                    [NameInMap("defaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EnableGzip</para>
                    /// </summary>
                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Engine</para>
                    /// </summary>
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Trigger</para>
                    /// </summary>
                    [NameInMap("inputType")]
                    [Validation(Required=false)]
                    public string InputType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("maxLength")]
                    [Validation(Required=false)]
                    public int? MaxLength { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>65535</para>
                    /// </summary>
                    [NameInMap("maxValue")]
                    [Validation(Required=false)]
                    public string MaxValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("minLength")]
                    [Validation(Required=false)]
                    public int? MinLength { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("minValue")]
                    [Validation(Required=false)]
                    public string MinValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>enable-gzip</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("readOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[a-z].*</para>
                    /// </summary>
                    [NameInMap("regex")]
                    [Validation(Required=false)]
                    public string Regex { get; set; }

                    [NameInMap("valueOptions")]
                    [Validation(Required=false)]
                    public List<ListGatewayFeaturesResponseBodyDataItemsDefinitionValueOptions> ValueOptions { get; set; }
                    public class ListGatewayFeaturesResponseBodyDataItemsDefinitionValueOptions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>KEEP_UNCHANGED</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bool</para>
                    /// </summary>
                    [NameInMap("valueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>byte</para>
                    /// </summary>
                    [NameInMap("valueUnit")]
                    [Validation(Required=false)]
                    public string ValueUnit { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;true&quot;</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
