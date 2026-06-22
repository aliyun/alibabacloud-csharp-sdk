// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeChartDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The available values for all subtypes of the chart.</para>
        /// </summary>
        [NameInMap("AllChartSubTypeList")]
        [Validation(Required=false)]
        public List<DescribeChartDataResponseBodyAllChartSubTypeList> AllChartSubTypeList { get; set; }
        public class DescribeChartDataResponseBodyAllChartSubTypeList : TeaModel {
            /// <summary>
            /// <para>The chart subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID_SUSPICIOUS_TREND-ALL</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>The chart subtype name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All Alerts</para>
            /// </summary>
            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }

        }

        /// <summary>
        /// <para>The chart data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>commonCoordinate</b>: common coordinate</description></item>
        /// <item><description><b>timeCoordinate</b>: time-axis coordinate</description></item>
        /// <item><description><b>multipleValue</b>: multiple values</description></item>
        /// <item><description><b>singleValue</b>: single value</description></item>
        /// <item><description><b>propertyValue</b>: property value</description></item>
        /// <item><description><b>propertyArrayValue</b>: array property value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>propertyArrayValue</para>
        /// </summary>
        [NameInMap("ChartDataType")]
        [Validation(Required=false)]
        public string ChartDataType { get; set; }

        /// <summary>
        /// <para>The list of selected chart subtype values.</para>
        /// </summary>
        [NameInMap("ChartSubTypeList")]
        [Validation(Required=false)]
        public List<string> ChartSubTypeList { get; set; }

        /// <summary>
        /// <para>The chart type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timeLine</b>: timeline chart</description></item>
        /// <item><description><b>timeBar</b>: time-axis bar chart</description></item>
        /// <item><description><b>bar</b>: bar chart</description></item>
        /// <item><description><b>line</b>: line chart</description></item>
        /// <item><description><b>pie</b>: pie chart</description></item>
        /// <item><description><b>gauge</b>: gauge chart</description></item>
        /// <item><description><b>table</b>: table</description></item>
        /// <item><description><b>text</b>: text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>timeBar</para>
        /// </summary>
        [NameInMap("ChartType")]
        [Validation(Required=false)]
        public string ChartType { get; set; }

        /// <summary>
        /// <para>The coordinate data.</para>
        /// </summary>
        [NameInMap("CoordinateData")]
        [Validation(Required=false)]
        public DescribeChartDataResponseBodyCoordinateData CoordinateData { get; set; }
        public class DescribeChartDataResponseBodyCoordinateData : TeaModel {
            /// <summary>
            /// <para>The list of X-axis values.</para>
            /// </summary>
            [NameInMap("XAxis")]
            [Validation(Required=false)]
            public List<string> XAxis { get; set; }

            /// <summary>
            /// <para>The list of Y-axis values.</para>
            /// </summary>
            [NameInMap("YAxisList")]
            [Validation(Required=false)]
            public List<DescribeChartDataResponseBodyCoordinateDataYAxisList> YAxisList { get; set; }
            public class DescribeChartDataResponseBodyCoordinateDataYAxisList : TeaModel {
                /// <summary>
                /// <para>The data type name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Port</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The chart subtype data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CID_SUSPICIOUS_TREND-AL</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The Y-axis values corresponding to each X-axis point.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The multiple-value chart data.</para>
        /// </summary>
        [NameInMap("MultipleData")]
        [Validation(Required=false)]
        public List<DescribeChartDataResponseBodyMultipleData> MultipleData { get; set; }
        public class DescribeChartDataResponseBodyMultipleData : TeaModel {
            /// <summary>
            /// <para>The font color in RGBA hexadecimal color code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#FFA800</para>
            /// </summary>
            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            /// <summary>
            /// <para>The data type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Safety</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>safe</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The property value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

        /// <summary>
        /// <para>The array chart property values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("PropertyArrayValue")]
        [Validation(Required=false)]
        public string PropertyArrayValue { get; set; }

        /// <summary>
        /// <para>The property value in the chart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;totalCount\&quot;: \&quot;0\&quot;}</para>
        /// </summary>
        [NameInMap("PropertyValue")]
        [Validation(Required=false)]
        public string PropertyValue { get; set; }

        /// <summary>
        /// <para>The property array of the chart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ProperyArrayValue")]
        [Validation(Required=false)]
        public string ProperyArrayValue { get; set; }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50CCE62A-2BC4-5CF8-B976-E4F62A31****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The single-value chart data.</para>
        /// </summary>
        [NameInMap("SingleData")]
        [Validation(Required=false)]
        public DescribeChartDataResponseBodySingleData SingleData { get; set; }
        public class DescribeChartDataResponseBodySingleData : TeaModel {
            /// <summary>
            /// <para>The data type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>suspicious</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>suspicious</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The data value of the single-value chart.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

    }

}
