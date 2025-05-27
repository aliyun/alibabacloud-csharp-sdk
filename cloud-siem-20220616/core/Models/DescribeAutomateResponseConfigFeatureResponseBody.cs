// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAutomateResponseConfigFeatureResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAutomateResponseConfigFeatureResponseBodyData> Data { get; set; }
        public class DescribeAutomateResponseConfigFeatureResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data type of the condition field in the automated response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The name of the condition field in the automated response rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alert_desc</para>
            /// </summary>
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// <para>The enumerated values of the right operand for the field.</para>
            /// </summary>
            [NameInMap("RightValueEnums")]
            [Validation(Required=false)]
            public List<DescribeAutomateResponseConfigFeatureResponseBodyDataRightValueEnums> RightValueEnums { get; set; }
            public class DescribeAutomateResponseConfigFeatureResponseBodyDataRightValueEnums : TeaModel {
                /// <summary>
                /// <para>The enumerated value of the right operand.</para>
                /// 
                /// <b>Example:</b>
                /// <para>serious</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The internal code of the enumerated value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun.siem.automate.feature.alert_level.serious</para>
                /// </summary>
                [NameInMap("ValueMds")]
                [Validation(Required=false)]
                public string ValueMds { get; set; }

            }

            /// <summary>
            /// <para>The operators that are supported for the condition field.</para>
            /// </summary>
            [NameInMap("SupportOperators")]
            [Validation(Required=false)]
            public List<DescribeAutomateResponseConfigFeatureResponseBodyDataSupportOperators> SupportOperators { get; set; }
            public class DescribeAutomateResponseConfigFeatureResponseBodyDataSupportOperators : TeaModel {
                /// <summary>
                /// <para>Indicates whether the right operand is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasRightValue")]
                [Validation(Required=false)]
                public bool? HasRightValue { get; set; }

                /// <summary>
                /// <para>The position of the operator in the operator list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&lt;=</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The description of the operator in Chinese.</para>
                /// 
                /// <b>Example:</b>
                /// <para>larger than or equal to</para>
                /// </summary>
                [NameInMap("OperatorDescCn")]
                [Validation(Required=false)]
                public string OperatorDescCn { get; set; }

                /// <summary>
                /// <para>The description of the operator in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>larger than or equal to</para>
                /// </summary>
                [NameInMap("OperatorDescEn")]
                [Validation(Required=false)]
                public string OperatorDescEn { get; set; }

                /// <summary>
                /// <para>The name of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&lt;=</para>
                /// </summary>
                [NameInMap("OperatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// <para>The data types that are supported by the operator. The data types are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>varchar</para>
                /// </summary>
                [NameInMap("SupportDataType")]
                [Validation(Required=false)]
                public string SupportDataType { get; set; }

                /// <summary>
                /// <para>The scenarios that are supported by the operator. Multiple scenarios are separated by commas (,), such as aggregation scenarios. By default, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[AGGREGATE]</para>
                /// </summary>
                [NameInMap("SupportTag")]
                [Validation(Required=false)]
                public List<string> SupportTag { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
