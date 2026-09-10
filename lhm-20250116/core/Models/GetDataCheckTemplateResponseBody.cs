// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The data body returned by the operation. For the field structure, refer to the child field descriptions below.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDataCheckTemplateResponseBodyData Data { get; set; }
        public class GetDataCheckTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of check rules for basic data type metrics. This field is required when checkType is set to 1 (metric comparison).</para>
            /// </summary>
            [NameInMap("basicMetricRules")]
            [Validation(Required=false)]
            public List<GetDataCheckTemplateResponseBodyDataBasicMetricRules> BasicMetricRules { get; set; }
            public class GetDataCheckTemplateResponseBodyDataBasicMetricRules : TeaModel {
                /// <summary>
                /// <para>The check methods (metric calculation methods). Multiple values are separated by commas, such as SUM,AVG,MIN,MAX. The values must be within the range allowed by the templatetype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUM,AVG</para>
                /// </summary>
                [NameInMap("checkMethods")]
                [Validation(Required=false)]
                public string CheckMethods { get; set; }

                /// <summary>
                /// <para>The data type category. Valid values: 0: primitive data type. 1: composite data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("dataTypeClassify")]
                [Validation(Required=false)]
                public int? DataTypeClassify { get; set; }

                /// <summary>
                /// <para>The data type group that identifies the data type category to which the check rule applies. The value is an integer from 0 to 7. For the meaning of each value, refer to the valid values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("dataTypeGroup")]
                [Validation(Required=false)]
                public int? DataTypeGroup { get; set; }

                /// <summary>
                /// <para>The list of data types to which the check rule applies. Configure this field as needed.</para>
                /// </summary>
                [NameInMap("dataTypeList")]
                [Validation(Required=false)]
                public List<string> DataTypeList { get; set; }

                /// <summary>
                /// <para>The data types. Configure this field as needed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIGINT</para>
                /// </summary>
                [NameInMap("dataTypes")]
                [Validation(Required=false)]
                public string DataTypes { get; set; }

                /// <summary>
                /// <para>The difference tolerance rate type. Valid values: 0: unified. 1: custom. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("diffTolerateType")]
                [Validation(Required=false)]
                public int? DiffTolerateType { get; set; }

                /// <summary>
                /// <para>The difference tolerance rate values. When the type is unified, one value is used. When the type is custom, values are set by the configured tolerance type, such as sum:33,avg:99.</para>
                /// </summary>
                [NameInMap("diffTolerateValues")]
                [Validation(Required=false)]
                public Dictionary<string, object> DiffTolerateValues { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable decimal scale control for DECIMAL type comparison. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("enableDecimalScale")]
                [Validation(Required=false)]
                public int? EnableDecimalScale { get; set; }

                /// <summary>
                /// <para>The filter column names, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a,col_b</para>
                /// </summary>
                [NameInMap("filterColumnName")]
                [Validation(Required=false)]
                public string FilterColumnName { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore trailing zeros in decimal places for DECIMAL type comparison. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreDecimalScaleSuffixZero")]
                [Validation(Required=false)]
                public int? IgnoreDecimalScaleSuffixZero { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore zero values for numeric types. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreNumericZero")]
                [Validation(Required=false)]
                public int? IgnoreNumericZero { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore empty strings and null for string types. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreStringEmpty")]
                [Validation(Required=false)]
                public int? IgnoreStringEmpty { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable count (data volume) check. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("isCountCheck")]
                [Validation(Required=false)]
                public int? IsCountCheck { get; set; }

                /// <summary>
                /// <para>The rule ID that uniquely identifies a check rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The specific number of decimal places for DECIMAL type comparison.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("setDecimalScale")]
                [Validation(Required=false)]
                public int? SetDecimalScale { get; set; }

            }

            /// <summary>
            /// <para>The check rule type. Valid values: 0: data volume comparison. 1: metric comparison. 2: weak content comparison. 3: custom comparison. 4: full-text comparison. 5: null rate comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The Chinese name of the check type (used in export report fields).</para>
            /// 
            /// <b>Example:</b>
            /// <para>指标比对</para>
            /// </summary>
            [NameInMap("checkTypeExport")]
            [Validation(Required=false)]
            public string CheckTypeExport { get; set; }

            /// <summary>
            /// <para>The check type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkTypeName")]
            [Validation(Required=false)]
            public int? CheckTypeName { get; set; }

            /// <summary>
            /// <para>The list of check rules for composite data type metrics. This field is used when checkType is set to 1 (metric comparison).</para>
            /// </summary>
            [NameInMap("complexMetricRules")]
            [Validation(Required=false)]
            public List<GetDataCheckTemplateResponseBodyDataComplexMetricRules> ComplexMetricRules { get; set; }
            public class GetDataCheckTemplateResponseBodyDataComplexMetricRules : TeaModel {
                /// <summary>
                /// <para>The check methods (metric calculation methods). Multiple values are separated by commas, such as SUM,AVG,MIN,MAX. The values must be within the range allowed by the templatetype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUM,AVG</para>
                /// </summary>
                [NameInMap("checkMethods")]
                [Validation(Required=false)]
                public string CheckMethods { get; set; }

                /// <summary>
                /// <para>The data type category. Valid values: 0: primitive data type. 1: composite data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("dataTypeClassify")]
                [Validation(Required=false)]
                public int? DataTypeClassify { get; set; }

                /// <summary>
                /// <para>The data type group that identifies the data type category to which the check rule applies. The value is an integer from 0 to 7. For the meaning of each value, refer to the valid values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("dataTypeGroup")]
                [Validation(Required=false)]
                public int? DataTypeGroup { get; set; }

                /// <summary>
                /// <para>The list of data types to which the check rule applies. Configure this field as needed.</para>
                /// </summary>
                [NameInMap("dataTypeList")]
                [Validation(Required=false)]
                public List<string> DataTypeList { get; set; }

                /// <summary>
                /// <para>The data types. Configure this field as needed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIGINT</para>
                /// </summary>
                [NameInMap("dataTypes")]
                [Validation(Required=false)]
                public string DataTypes { get; set; }

                /// <summary>
                /// <para>The difference tolerance rate type. Valid values: 0: unified. 1: custom. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("diffTolerateType")]
                [Validation(Required=false)]
                public int? DiffTolerateType { get; set; }

                /// <summary>
                /// <para>The difference tolerance rate values. When the type is unified, one value is used. When the type is custom, values are set by the configured tolerance type, such as sum:33,avg:99.</para>
                /// </summary>
                [NameInMap("diffTolerateValues")]
                [Validation(Required=false)]
                public Dictionary<string, object> DiffTolerateValues { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable decimal scale control for DECIMAL type comparison. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("enableDecimalScale")]
                [Validation(Required=false)]
                public int? EnableDecimalScale { get; set; }

                /// <summary>
                /// <para>The filter column names, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a,col_b</para>
                /// </summary>
                [NameInMap("filterColumnName")]
                [Validation(Required=false)]
                public string FilterColumnName { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore trailing zeros in decimal places for DECIMAL type comparison. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreDecimalScaleSuffixZero")]
                [Validation(Required=false)]
                public int? IgnoreDecimalScaleSuffixZero { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore zero values for numeric types. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreNumericZero")]
                [Validation(Required=false)]
                public int? IgnoreNumericZero { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore empty strings and null for string types. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreStringEmpty")]
                [Validation(Required=false)]
                public int? IgnoreStringEmpty { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable count (data volume) check. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("isCountCheck")]
                [Validation(Required=false)]
                public int? IsCountCheck { get; set; }

                /// <summary>
                /// <para>The rule ID that uniquely identifies a check rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The specific number of decimal places for DECIMAL type comparison.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("setDecimalScale")]
                [Validation(Required=false)]
                public int? SetDecimalScale { get; set; }

            }

            /// <summary>
            /// <para>The list of data source engine relationships (data source engines associated with the template).</para>
            /// </summary>
            [NameInMap("dsEngineRels")]
            [Validation(Required=false)]
            public List<GetDataCheckTemplateResponseBodyDataDsEngineRels> DsEngineRels { get; set; }
            public class GetDataCheckTemplateResponseBodyDataDsEngineRels : TeaModel {
                /// <summary>
                /// <para>The data source type, such as Hive or MaxCompute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hive</para>
                /// </summary>
                [NameInMap("dsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                /// <summary>
                /// <para>The list of covered check engine types, such as Tez or MapReduce. When in string format, multiple values are separated by commas.</para>
                /// </summary>
                [NameInMap("engineTypes")]
                [Validation(Required=false)]
                public List<string> EngineTypes { get; set; }

            }

            /// <summary>
            /// <para>The full-text comparison rule. This field has a value when checkType is set to 4 (full-text comparison). For the field structure, refer to the child field descriptions below.</para>
            /// </summary>
            [NameInMap("fulltextRule")]
            [Validation(Required=false)]
            public GetDataCheckTemplateResponseBodyDataFulltextRule FulltextRule { get; set; }
            public class GetDataCheckTemplateResponseBodyDataFulltextRule : TeaModel {
                /// <summary>
                /// <para>The check mode. Valid values: 0: row-level overall comparison. 1: row-level column-by-column comparison. 2: both row-level overall comparison and row-level column-by-column comparison.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("checkMode")]
                [Validation(Required=false)]
                public int? CheckMode { get; set; }

                /// <summary>
                /// <para>The equality comparison type for row-level column-by-column comparison. Valid values: 0: all field types. 1: primitive basic data types. 2: composite data types. 3: custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("columnEqualCmpType")]
                [Validation(Required=false)]
                public int? ColumnEqualCmpType { get; set; }

                /// <summary>
                /// <para>The custom type list for equality comparison during row-level column-by-column comparison. Multiple values are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ARRAY,MAP</para>
                /// </summary>
                [NameInMap("columnEqualCmpValues")]
                [Validation(Required=false)]
                public string ColumnEqualCmpValues { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable cosine similarity for row-level column-by-column comparison. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("columnIsCosine")]
                [Validation(Required=false)]
                public int? ColumnIsCosine { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore differences between null values and empty strings during row-by-row and column-by-column comparison. Valid values: 0: No. 1: Yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("columnIsIgnoreNull")]
                [Validation(Required=false)]
                public int? ColumnIsIgnoreNull { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore differences between null values and 0 values during row-by-row and column-by-column comparison. Valid values: 0: No. 1: Yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("columnIsIgnoreZero")]
                [Validation(Required=false)]
                public int? ColumnIsIgnoreZero { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable sampling during row-by-row and column-by-column comparison. Valid values: 0: No. 1: Yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("columnIsSamples")]
                [Validation(Required=false)]
                public int? ColumnIsSamples { get; set; }

                /// <summary>
                /// <para>The sampling method during row-by-row and column-by-column comparison. Valid values: 0: by row. 1: by percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("columnSamplesType")]
                [Validation(Required=false)]
                public int? ColumnSamplesType { get; set; }

                /// <summary>
                /// <para>The sampling value during row-by-row and column-by-column comparison. The meaning depends on the sampling method. When sampling by row, this value represents the number of rows. When sampling by percentage, this value represents the percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("columnSamplesValue")]
                [Validation(Required=false)]
                public int? ColumnSamplesValue { get; set; }

                /// <summary>
                /// <para>The size comparison type during row-by-row and column-by-column comparison. Valid values: 0: all composite data types. 1: custom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("columnSizeCmpType")]
                [Validation(Required=false)]
                public int? ColumnSizeCmpType { get; set; }

                /// <summary>
                /// <para>The custom type list for size comparison during row-by-row and column-by-column comparison. Multiple values are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ARRAY,MAP</para>
                /// </summary>
                [NameInMap("columnSizeCmpValues")]
                [Validation(Required=false)]
                public string ColumnSizeCmpValues { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the existence check for primary keys or composite primary keys. Valid values: 0: No. 1: Yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("isPrimaryKeyCheck")]
                [Validation(Required=false)]
                public int? IsPrimaryKeyCheck { get; set; }

                /// <summary>
                /// <para>The row-by-row comparison method. Valid values: 0: md5. 1: crc32.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("lineCheckType")]
                [Validation(Required=false)]
                public int? LineCheckType { get; set; }

                /// <summary>
                /// <para>Specifies whether to print all columns in the difference details during row-by-row comparison. Valid values: 0: No. 1: Yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("lineIsPrintAll")]
                [Validation(Required=false)]
                public int? LineIsPrintAll { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable sampling during row-by-row comparison. Valid values: 0: No. 1: Yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("lineIsSamples")]
                [Validation(Required=false)]
                public int? LineIsSamples { get; set; }

                /// <summary>
                /// <para>The sampling method during row-by-row comparison. Valid values: 0: by row. 1: by percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("lineSamplesType")]
                [Validation(Required=false)]
                public int? LineSamplesType { get; set; }

                /// <summary>
                /// <para>The sampling value during row-by-row comparison. The meaning depends on the sampling method. When sampling by row, this value represents the number of rows. When sampling by percentage, this value represents the percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("lineSamplesValue")]
                [Validation(Required=false)]
                public int? LineSamplesValue { get; set; }

                /// <summary>
                /// <para>The rule ID that uniquely identifies a check rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

            /// <summary>
            /// <para>The list of metric check rules. This parameter has a value when checkType is set to 1 (metric comparison).</para>
            /// </summary>
            [NameInMap("metricRules")]
            [Validation(Required=false)]
            public List<GetDataCheckTemplateResponseBodyDataMetricRules> MetricRules { get; set; }
            public class GetDataCheckTemplateResponseBodyDataMetricRules : TeaModel {
                /// <summary>
                /// <para>The check methods (metric calculation methods). Multiple values are separated by commas (,), such as SUM,AVG,MIN,MAX. The values must be within the range allowed by the templatetype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUM,AVG</para>
                /// </summary>
                [NameInMap("checkMethods")]
                [Validation(Required=false)]
                public string CheckMethods { get; set; }

                /// <summary>
                /// <para>The data type category. Valid values: 0: primitive data type. 1: composite data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("dataTypeClassify")]
                [Validation(Required=false)]
                public int? DataTypeClassify { get; set; }

                /// <summary>
                /// <para>The data type group that identifies the data type category to which the check rule applies. The value is an integer from 0 to 7. For the meaning of each value, refer to the valid values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("dataTypeGroup")]
                [Validation(Required=false)]
                public int? DataTypeGroup { get; set; }

                /// <summary>
                /// <para>The list of data types to which the check rule applies. Configure this field as needed.</para>
                /// </summary>
                [NameInMap("dataTypeList")]
                [Validation(Required=false)]
                public List<string> DataTypeList { get; set; }

                /// <summary>
                /// <para>The data types. Configure this field as needed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIGINT</para>
                /// </summary>
                [NameInMap("dataTypes")]
                [Validation(Required=false)]
                public string DataTypes { get; set; }

                /// <summary>
                /// <para>The difference tolerance rate type. Valid values: 0: unified. 1: custom. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("diffTolerateType")]
                [Validation(Required=false)]
                public int? DiffTolerateType { get; set; }

                /// <summary>
                /// <para>The difference tolerance rate values. When the type is unified, one value is used. When the type is custom, values are set by the configured tolerance type, such as sum:33,avg:99.</para>
                /// </summary>
                [NameInMap("diffTolerateValues")]
                [Validation(Required=false)]
                public Dictionary<string, object> DiffTolerateValues { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable decimal scale control for DECIMAL type comparison. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("enableDecimalScale")]
                [Validation(Required=false)]
                public int? EnableDecimalScale { get; set; }

                /// <summary>
                /// <para>The filter column names, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col_a,col_b</para>
                /// </summary>
                [NameInMap("filterColumnName")]
                [Validation(Required=false)]
                public string FilterColumnName { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore trailing zeros in decimal places for DECIMAL type comparison. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreDecimalScaleSuffixZero")]
                [Validation(Required=false)]
                public int? IgnoreDecimalScaleSuffixZero { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore zero values for numeric types. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreNumericZero")]
                [Validation(Required=false)]
                public int? IgnoreNumericZero { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore empty strings and null for string types. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ignoreStringEmpty")]
                [Validation(Required=false)]
                public int? IgnoreStringEmpty { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable count (data volume) check. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("isCountCheck")]
                [Validation(Required=false)]
                public int? IsCountCheck { get; set; }

                /// <summary>
                /// <para>The rule ID that uniquely identifies a check rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The specific number of decimal places for DECIMAL type comparison.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("setDecimalScale")]
                [Validation(Required=false)]
                public int? SetDecimalScale { get; set; }

            }

            /// <summary>
            /// <para>The list of null rate check rules. This parameter has a value when checkType is set to 5 (null rate comparison).</para>
            /// </summary>
            [NameInMap("nullRules")]
            [Validation(Required=false)]
            public List<GetDataCheckTemplateResponseBodyDataNullRules> NullRules { get; set; }
            public class GetDataCheckTemplateResponseBodyDataNullRules : TeaModel {
                /// <summary>
                /// <para>The data type group that identifies the data type category to which the check rule applies. The value is an integer from 0 to 7. For the meaning of each value, refer to the valid values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("dataTypeGroup")]
                [Validation(Required=false)]
                public int? DataTypeGroup { get; set; }

                /// <summary>
                /// <para>The null values, stored in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("nullValues")]
                [Validation(Required=false)]
                public string NullValues { get; set; }

                /// <summary>
                /// <para>The rule ID that uniquely identifies a check rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

            /// <summary>
            /// <para>The template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description of the data volume check template</para>
            /// </summary>
            [NameInMap("templateDesc")]
            [Validation(Required=false)]
            public string TemplateDesc { get; set; }

            /// <summary>
            /// <para>The check template ID (logical foreign key) that uniquely identifies a check template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the check template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data volume check template</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The weak content check rule. This parameter has a value and is required when checkType is set to 2 (weak content comparison). For the field structure, see the child field descriptions.</para>
            /// </summary>
            [NameInMap("weakContentRule")]
            [Validation(Required=false)]
            public GetDataCheckTemplateResponseBodyDataWeakContentRule WeakContentRule { get; set; }
            public class GetDataCheckTemplateResponseBodyDataWeakContentRule : TeaModel {
                /// <summary>
                /// <para>The filter column name expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^col_.*$</para>
                /// </summary>
                [NameInMap("filterColumnExpression")]
                [Validation(Required=false)]
                public string FilterColumnExpression { get; set; }

                /// <summary>
                /// <para>The filter column types, separated by vertical bars (|).</para>
                /// </summary>
                [NameInMap("filterColumnTypes")]
                [Validation(Required=false)]
                public List<string> FilterColumnTypes { get; set; }

                /// <summary>
                /// <para>The rule ID that uniquely identifies a check rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The weak content algorithm name. Valid values: md5 and crc32.</para>
                /// 
                /// <b>Example:</b>
                /// <para>md5</para>
                /// </summary>
                [NameInMap("weakContentAlgorithm")]
                [Validation(Required=false)]
                public string WeakContentAlgorithm { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: true: The call is successful. false: The call failed. If the call failed, check errCode and errMessage for details.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
