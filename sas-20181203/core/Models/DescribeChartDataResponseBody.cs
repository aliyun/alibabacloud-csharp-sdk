// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeChartDataResponseBody : TeaModel {
        /// <summary>
        /// The valid values for all subtypes of the chart.
        /// </summary>
        [NameInMap("AllChartSubTypeList")]
        [Validation(Required=false)]
        public List<DescribeChartDataResponseBodyAllChartSubTypeList> AllChartSubTypeList { get; set; }
        public class DescribeChartDataResponseBodyAllChartSubTypeList : TeaModel {
            /// <summary>
            /// The subtype of the chart.
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// The name of the chart subtype.
            /// </summary>
            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }

        }

        /// <summary>
        /// The data type of the chart. Valid values:
        /// 
        /// *   **commonCoordinate**
        /// *   **timeCoordinate**
        /// *   **multipleValue**
        /// *   **singleValue**
        /// *   **propertyValue**
        /// *   **propertyArrayValue**
        /// </summary>
        [NameInMap("ChartDataType")]
        [Validation(Required=false)]
        public string ChartDataType { get; set; }

        /// <summary>
        /// The subtype values in which the chart is selected.
        /// </summary>
        [NameInMap("ChartSubTypeList")]
        [Validation(Required=false)]
        public List<string> ChartSubTypeList { get; set; }

        /// <summary>
        /// The type of the chart. Valid values:
        /// 
        /// *   **timeLine**
        /// *   **timeBar**
        /// *   **bar**
        /// *   **line**
        /// *   **pie**
        /// *   **gauge**
        /// *   **table**
        /// *   **text**
        /// </summary>
        [NameInMap("ChartType")]
        [Validation(Required=false)]
        public string ChartType { get; set; }

        /// <summary>
        /// The coordinate data.
        /// </summary>
        [NameInMap("CoordinateData")]
        [Validation(Required=false)]
        public DescribeChartDataResponseBodyCoordinateData CoordinateData { get; set; }
        public class DescribeChartDataResponseBodyCoordinateData : TeaModel {
            /// <summary>
            /// The x-axis values.
            /// </summary>
            [NameInMap("XAxis")]
            [Validation(Required=false)]
            public List<string> XAxis { get; set; }

            /// <summary>
            /// The y-axis values.
            /// </summary>
            [NameInMap("YAxisList")]
            [Validation(Required=false)]
            public List<DescribeChartDataResponseBodyCoordinateDataYAxisList> YAxisList { get; set; }
            public class DescribeChartDataResponseBodyCoordinateDataYAxisList : TeaModel {
                /// <summary>
                /// The name of the data type.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The subtype data of the chart.
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// The type of the data.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The values of the y-axis that corresponds to x-axis points.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

        }

        /// <summary>
        /// The values in the multi-value charts.
        /// </summary>
        [NameInMap("MultipleData")]
        [Validation(Required=false)]
        public List<DescribeChartDataResponseBodyMultipleData> MultipleData { get; set; }
        public class DescribeChartDataResponseBodyMultipleData : TeaModel {
            /// <summary>
            /// The font color, which is an RGBA value.
            /// </summary>
            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            /// <summary>
            /// The name of the data type.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the data.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The attribute value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

        /// <summary>
        /// The attribute value of the array chart.
        /// </summary>
        [NameInMap("PropertyArrayValue")]
        [Validation(Required=false)]
        public string PropertyArrayValue { get; set; }

        /// <summary>
        /// The data of the chart.
        /// </summary>
        [NameInMap("PropertyValue")]
        [Validation(Required=false)]
        public string PropertyValue { get; set; }

        /// <summary>
        /// The array data of the chart.
        /// </summary>
        [NameInMap("ProperyArrayValue")]
        [Validation(Required=false)]
        public string ProperyArrayValue { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The data of the single value chart.
        /// </summary>
        [NameInMap("SingleData")]
        [Validation(Required=false)]
        public DescribeChartDataResponseBodySingleData SingleData { get; set; }
        public class DescribeChartDataResponseBodySingleData : TeaModel {
            /// <summary>
            /// The name of the data type.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the data.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The value in the single value chart.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

    }

}
