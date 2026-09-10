// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class AddDataCheckTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The list of metric verification rules for basic data types. This field is required when checkType is set to 1 (metric comparison).</para>
        /// </summary>
        [NameInMap("basicMetricRules")]
        [Validation(Required=false)]
        public List<AddDataCheckTemplateRequestBasicMetricRules> BasicMetricRules { get; set; }
        public class AddDataCheckTemplateRequestBasicMetricRules : TeaModel {
            /// <summary>
            /// <para>The verification methods (metric calculation methods). Separate multiple values with commas (,), such as SUM,AVG,MIN,MAX. The values must be within the range allowed by the templatetype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUM,AVG</para>
            /// </summary>
            [NameInMap("checkMethods")]
            [Validation(Required=false)]
            public string CheckMethods { get; set; }

            /// <summary>
            /// <para>Specifies whether to control floating-point precision. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("controlFloatPrecision")]
            [Validation(Required=false)]
            public int? ControlFloatPrecision { get; set; }

            /// <summary>
            /// <para>The data type category. Valid values: 0 (native data type) and 1 (composite data type).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeClassify")]
            [Validation(Required=false)]
            public int? DataTypeClassify { get; set; }

            /// <summary>
            /// <para>The data type group that identifies the data type category to which the verification rule applies. Valid values: integers from 0 to 7. For the description of each value, see the enumeration values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            /// <summary>
            /// <para>The list of data types to which the verification rule applies. Configure this field based on your requirements.</para>
            /// </summary>
            [NameInMap("dataTypeList")]
            [Validation(Required=false)]
            public List<string> DataTypeList { get; set; }

            /// <summary>
            /// <para>The data types. Configure this field based on your requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("dataTypes")]
            [Validation(Required=false)]
            public string DataTypes { get; set; }

            /// <summary>
            /// <para>The difference tolerance rate type. Valid values: 0 (unified) and 1 (custom). Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("diffTolerateType")]
            [Validation(Required=false)]
            public int? DiffTolerateType { get; set; }

            /// <summary>
            /// <para>The difference tolerance rate values. For the unified type, specify one value, such as {&quot;SAME&quot;: 0}. For the custom type, specify a value for each tolerance type, such as {&quot;SUM&quot;: 0.01, &quot;AVG&quot;: 0.001}.</para>
            /// </summary>
            [NameInMap("diffTolerateValues")]
            [Validation(Required=false)]
            public Dictionary<string, object> DiffTolerateValues { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable decimal scale control for DECIMAL type comparison. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("enableDecimalScale")]
            [Validation(Required=false)]
            public int? EnableDecimalScale { get; set; }

            /// <summary>
            /// <para>The filter field names, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumnName")]
            [Validation(Required=false)]
            public string FilterColumnName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Use the filterColumnName field instead. This field is retained for backward compatibility.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumns")]
            [Validation(Required=false)]
            public string FilterColumns { get; set; }

            /// <summary>
            /// <para>The number of decimal places for floating-point values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floatPrecision")]
            [Validation(Required=false)]
            public int? FloatPrecision { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore trailing zero differences in decimal parts. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalDiff")]
            [Validation(Required=false)]
            public int? IgnoreDecimalDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore trailing zeros in the decimal scale for DECIMAL type comparison. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalScaleSuffixZero")]
            [Validation(Required=false)]
            public int? IgnoreDecimalScaleSuffixZero { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and empty strings. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreEmptyDiff")]
            [Validation(Required=false)]
            public int? IgnoreEmptyDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore zero values for numeric types. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreNumericZero")]
            [Validation(Required=false)]
            public int? IgnoreNumericZero { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore empty strings and null values for string types. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreStringEmpty")]
            [Validation(Required=false)]
            public int? IgnoreStringEmpty { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and zero values. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreZeroDiff")]
            [Validation(Required=false)]
            public int? IgnoreZeroDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable count (data volume) verification. Valid values: 0 (no) and 1 (yes). Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isCountCheck")]
            [Validation(Required=false)]
            public int? IsCountCheck { get; set; }

            /// <summary>
            /// <para>The rule ID that uniquely identifies a verification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The specific decimal scale value for DECIMAL type comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("setDecimalScale")]
            [Validation(Required=false)]
            public int? SetDecimalScale { get; set; }

        }

        /// <summary>
        /// <para>The verification rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: data volume comparison.</description></item>
        /// <item><description>1: metric comparison.</description></item>
        /// <item><description>2: weak content comparison.</description></item>
        /// <item><description>3: custom comparison.</description></item>
        /// <item><description>4: full-text comparison.</description></item>
        /// <item><description>5: null rate comparison.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("checkType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The list of check rules for complex data type metrics. Used when checkType is set to 1 (metric comparison).</para>
        /// </summary>
        [NameInMap("complexMetricRules")]
        [Validation(Required=false)]
        public List<AddDataCheckTemplateRequestComplexMetricRules> ComplexMetricRules { get; set; }
        public class AddDataCheckTemplateRequestComplexMetricRules : TeaModel {
            /// <summary>
            /// <para>The check methods (metric calculation methods). Separate multiple values with commas, such as SUM,AVG,MIN,MAX. The values must be within the range allowed by the templatetype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUM,AVG</para>
            /// </summary>
            [NameInMap("checkMethods")]
            [Validation(Required=false)]
            public string CheckMethods { get; set; }

            /// <summary>
            /// <para>Specifies whether to control floating-point precision. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("controlFloatPrecision")]
            [Validation(Required=false)]
            public int? ControlFloatPrecision { get; set; }

            /// <summary>
            /// <para>The data type category. Valid values: 0 (native data type) and 1 (composite data type).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeClassify")]
            [Validation(Required=false)]
            public int? DataTypeClassify { get; set; }

            /// <summary>
            /// <para>The data type group that identifies the data type category to which the verification rule applies. Valid values: integers from 0 to 7. For the description of each value, see the enumeration values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            /// <summary>
            /// <para>The list of data types to which the verification rule applies. Configure this field based on your requirements.</para>
            /// </summary>
            [NameInMap("dataTypeList")]
            [Validation(Required=false)]
            public List<string> DataTypeList { get; set; }

            /// <summary>
            /// <para>The data types. Configure this field based on your requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("dataTypes")]
            [Validation(Required=false)]
            public string DataTypes { get; set; }

            /// <summary>
            /// <para>The difference tolerance rate type. Valid values: 0 (unified) and 1 (custom). Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("diffTolerateType")]
            [Validation(Required=false)]
            public int? DiffTolerateType { get; set; }

            /// <summary>
            /// <para>The difference tolerance rate values. For the unified type, specify one value, such as {&quot;SAME&quot;: 0}. For the custom type, specify a value for each tolerance type, such as {&quot;SUM&quot;: 0.01, &quot;AVG&quot;: 0.001}.</para>
            /// </summary>
            [NameInMap("diffTolerateValues")]
            [Validation(Required=false)]
            public Dictionary<string, object> DiffTolerateValues { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable decimal scale control for DECIMAL type comparison. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("enableDecimalScale")]
            [Validation(Required=false)]
            public int? EnableDecimalScale { get; set; }

            /// <summary>
            /// <para>The filter field names, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumnName")]
            [Validation(Required=false)]
            public string FilterColumnName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Use the filterColumnName field instead. This field is retained for backward compatibility.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumns")]
            [Validation(Required=false)]
            public string FilterColumns { get; set; }

            /// <summary>
            /// <para>The number of decimal places for floating-point values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floatPrecision")]
            [Validation(Required=false)]
            public int? FloatPrecision { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore trailing zero differences in decimal parts. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalDiff")]
            [Validation(Required=false)]
            public int? IgnoreDecimalDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore trailing zeros in the decimal scale for DECIMAL type comparison. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalScaleSuffixZero")]
            [Validation(Required=false)]
            public int? IgnoreDecimalScaleSuffixZero { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and empty strings. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreEmptyDiff")]
            [Validation(Required=false)]
            public int? IgnoreEmptyDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore zero values for numeric types. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreNumericZero")]
            [Validation(Required=false)]
            public int? IgnoreNumericZero { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore empty strings and null values for string types. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreStringEmpty")]
            [Validation(Required=false)]
            public int? IgnoreStringEmpty { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and zero values. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreZeroDiff")]
            [Validation(Required=false)]
            public int? IgnoreZeroDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable count (data volume) verification. Valid values: 0 (no) and 1 (yes). Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isCountCheck")]
            [Validation(Required=false)]
            public int? IsCountCheck { get; set; }

            /// <summary>
            /// <para>The rule ID that uniquely identifies a verification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The specific decimal scale value for DECIMAL type comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("setDecimalScale")]
            [Validation(Required=false)]
            public int? SetDecimalScale { get; set; }

        }

        /// <summary>
        /// <para>The list of datasource engine relationships (datasource engines associated with the template).</para>
        /// </summary>
        [NameInMap("dsEngineRels")]
        [Validation(Required=false)]
        public List<AddDataCheckTemplateRequestDsEngineRels> DsEngineRels { get; set; }
        public class AddDataCheckTemplateRequestDsEngineRels : TeaModel {
            /// <summary>
            /// <para>The ID of the datasource engine configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("dsEngineId")]
            [Validation(Required=false)]
            public string DsEngineId { get; set; }

            /// <summary>
            /// <para>The datasource type, such as Hive or MaxCompute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("dsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            /// <summary>
            /// <para>The list of covered check engine types, such as Tez or MapReduce. When specified as a string, separate multiple values with commas.</para>
            /// </summary>
            [NameInMap("engineTypes")]
            [Validation(Required=false)]
            public List<string> EngineTypes { get; set; }

        }

        /// <summary>
        /// <para>The full-text comparison rule. This parameter has a value when checkType is set to 4 (full-text comparison). For the field structure, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("fulltextRule")]
        [Validation(Required=false)]
        public AddDataCheckTemplateRequestFulltextRule FulltextRule { get; set; }
        public class AddDataCheckTemplateRequestFulltextRule : TeaModel {
            /// <summary>
            /// <para>The check mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: row-by-row overall comparison.</description></item>
            /// <item><description>1: row-by-row column-by-column comparison.</description></item>
            /// <item><description>2: both row-by-row overall comparison and row-by-row column-by-column comparison.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("checkMode")]
            [Validation(Required=false)]
            public int? CheckMode { get; set; }

            /// <summary>
            /// <para>The equality comparison type for row-by-row column-by-column comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: all field types.</description></item>
            /// <item><description>1: native primitive data types.</description></item>
            /// <item><description>2: complex data types.</description></item>
            /// <item><description>3: custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnEqualCmpType")]
            [Validation(Required=false)]
            public int? ColumnEqualCmpType { get; set; }

            /// <summary>
            /// <para>The custom type list for equality comparison during row-by-row column-by-column comparison. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ARRAY,MAP</para>
            /// </summary>
            [NameInMap("columnEqualCmpValues")]
            [Validation(Required=false)]
            public string ColumnEqualCmpValues { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable cosine similarity during row-by-row column-by-column comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsCosine")]
            [Validation(Required=false)]
            public int? ColumnIsCosine { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and empty strings during row-by-row column-by-column comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not ignored.</description></item>
            /// <item><description>1: Ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsIgnoreNull")]
            [Validation(Required=false)]
            public int? ColumnIsIgnoreNull { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and 0 values during row-by-row column-by-column comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not ignored.</description></item>
            /// <item><description>1: Ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsIgnoreZero")]
            [Validation(Required=false)]
            public int? ColumnIsIgnoreZero { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable sampling during row-by-row column-by-column comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsSamples")]
            [Validation(Required=false)]
            public int? ColumnIsSamples { get; set; }

            /// <summary>
            /// <para>The sampling method for row-by-row column-by-column comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: by row.</description></item>
            /// <item><description>1: by percentage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnSamplesType")]
            [Validation(Required=false)]
            public int? ColumnSamplesType { get; set; }

            /// <summary>
            /// <para>The sampling value for row-by-row column-by-column comparison. The meaning depends on the sampling method: the number of rows when sampling by row, or the percentage value when sampling by percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("columnSamplesValue")]
            [Validation(Required=false)]
            public int? ColumnSamplesValue { get; set; }

            /// <summary>
            /// <para>The size comparison type for row-by-row column-by-column comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: all complex data types.</description></item>
            /// <item><description>1: custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnSizeCmpType")]
            [Validation(Required=false)]
            public int? ColumnSizeCmpType { get; set; }

            /// <summary>
            /// <para>The custom type list for size comparison during row-by-row column-by-column comparison. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ARRAY,MAP</para>
            /// </summary>
            [NameInMap("columnSizeCmpValues")]
            [Validation(Required=false)]
            public string ColumnSizeCmpValues { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable primary key or composite primary key existence check. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isPrimaryKeyCheck")]
            [Validation(Required=false)]
            public int? IsPrimaryKeyCheck { get; set; }

            /// <summary>
            /// <para>The row-by-row comparison method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: md5.</description></item>
            /// <item><description>1: crc32.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineCheckType")]
            [Validation(Required=false)]
            public int? LineCheckType { get; set; }

            /// <summary>
            /// <para>Specifies whether to print all columns in the difference details during row-by-row comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not printed.</description></item>
            /// <item><description>1: Printed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineIsPrintAll")]
            [Validation(Required=false)]
            public int? LineIsPrintAll { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable sampling during row-by-row comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Disabled.</description></item>
            /// <item><description>1: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineIsSamples")]
            [Validation(Required=false)]
            public int? LineIsSamples { get; set; }

            /// <summary>
            /// <para>The sampling method for row-by-row comparison. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: by row.</description></item>
            /// <item><description>1: by percentage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineSamplesType")]
            [Validation(Required=false)]
            public int? LineSamplesType { get; set; }

            /// <summary>
            /// <para>The sampling value for row-by-row comparison. The meaning depends on the sampling method: the number of rows when sampling by row, or the percentage value when sampling by percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("lineSamplesValue")]
            [Validation(Required=false)]
            public int? LineSamplesValue { get; set; }

            /// <summary>
            /// <para>The rule ID that uniquely identifies a verification rule.</para>
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
        public List<AddDataCheckTemplateRequestMetricRules> MetricRules { get; set; }
        public class AddDataCheckTemplateRequestMetricRules : TeaModel {
            /// <summary>
            /// <para>The check methods (metric calculation methods). Separate multiple values with commas, such as SUM,AVG,MIN,MAX. The values must be within the range allowed by the templatetype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUM,AVG</para>
            /// </summary>
            [NameInMap("checkMethods")]
            [Validation(Required=false)]
            public string CheckMethods { get; set; }

            /// <summary>
            /// <para>Specifies whether to control floating-point precision. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("controlFloatPrecision")]
            [Validation(Required=false)]
            public int? ControlFloatPrecision { get; set; }

            /// <summary>
            /// <para>The data type category. Valid values: 0 (native data type) and 1 (composite data type).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeClassify")]
            [Validation(Required=false)]
            public int? DataTypeClassify { get; set; }

            /// <summary>
            /// <para>The data type group that identifies the data type category to which the verification rule applies. Valid values: integers from 0 to 7. For the description of each value, see the enumeration values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            /// <summary>
            /// <para>The list of data types to which the verification rule applies. Configure this field based on your requirements.</para>
            /// </summary>
            [NameInMap("dataTypeList")]
            [Validation(Required=false)]
            public List<string> DataTypeList { get; set; }

            /// <summary>
            /// <para>The data types. Configure this field based on your requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("dataTypes")]
            [Validation(Required=false)]
            public string DataTypes { get; set; }

            /// <summary>
            /// <para>The difference tolerance rate type. Valid values: 0 (unified) and 1 (custom). Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("diffTolerateType")]
            [Validation(Required=false)]
            public int? DiffTolerateType { get; set; }

            /// <summary>
            /// <para>The difference tolerance rate values. For the unified type, specify one value, such as {&quot;SAME&quot;: 0}. For the custom type, specify a value for each tolerance type, such as {&quot;SUM&quot;: 0.01, &quot;AVG&quot;: 0.001}.</para>
            /// </summary>
            [NameInMap("diffTolerateValues")]
            [Validation(Required=false)]
            public Dictionary<string, object> DiffTolerateValues { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable decimal scale control for DECIMAL type comparison. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("enableDecimalScale")]
            [Validation(Required=false)]
            public int? EnableDecimalScale { get; set; }

            /// <summary>
            /// <para>The filter field names, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumnName")]
            [Validation(Required=false)]
            public string FilterColumnName { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Use the filterColumnName field instead. This field is retained for backward compatibility.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumns")]
            [Validation(Required=false)]
            public string FilterColumns { get; set; }

            /// <summary>
            /// <para>The number of decimal places for floating-point values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floatPrecision")]
            [Validation(Required=false)]
            public int? FloatPrecision { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore trailing zero differences in decimal parts. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalDiff")]
            [Validation(Required=false)]
            public int? IgnoreDecimalDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore trailing zeros in the decimal scale for DECIMAL type comparison. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalScaleSuffixZero")]
            [Validation(Required=false)]
            public int? IgnoreDecimalScaleSuffixZero { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and empty strings. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreEmptyDiff")]
            [Validation(Required=false)]
            public int? IgnoreEmptyDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore zero values for numeric types. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreNumericZero")]
            [Validation(Required=false)]
            public int? IgnoreNumericZero { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore empty strings and null values for string types. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreStringEmpty")]
            [Validation(Required=false)]
            public int? IgnoreStringEmpty { get; set; }

            /// <summary>
            /// <para>Specifies whether to ignore differences between null values and zero values. Valid values: 0 (no) and 1 (yes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreZeroDiff")]
            [Validation(Required=false)]
            public int? IgnoreZeroDiff { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable count (data volume) verification. Valid values: 0 (no) and 1 (yes). Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isCountCheck")]
            [Validation(Required=false)]
            public int? IsCountCheck { get; set; }

            /// <summary>
            /// <para>The rule ID that uniquely identifies a verification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The specific decimal scale value for DECIMAL type comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("setDecimalScale")]
            [Validation(Required=false)]
            public int? SetDecimalScale { get; set; }

        }

        /// <summary>
        /// <para>The list of null value rate check rules. This parameter has a value when checkType is set to 5 (null value rate comparison).</para>
        /// </summary>
        [NameInMap("nullRules")]
        [Validation(Required=false)]
        public List<AddDataCheckTemplateRequestNullRules> NullRules { get; set; }
        public class AddDataCheckTemplateRequestNullRules : TeaModel {
            /// <summary>
            /// <para>The data type group that identifies the data type category to which the verification rule applies. Valid values: integers from 0 to 7. For the description of each value, see the enumeration values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            /// <summary>
            /// <para>The null value definitions, stored in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("nullValues")]
            [Validation(Required=false)]
            public string NullValues { get; set; }

            /// <summary>
            /// <para>The rule ID that uniquely identifies a verification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues of this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The name of the check template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data volume check template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The weak content check rule. This parameter has a value and is required when checkType is set to 2 (weak content comparison). For the field structure, refer to the child field descriptions below.</para>
        /// </summary>
        [NameInMap("weakContentRule")]
        [Validation(Required=false)]
        public AddDataCheckTemplateRequestWeakContentRule WeakContentRule { get; set; }
        public class AddDataCheckTemplateRequestWeakContentRule : TeaModel {
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
            /// <para>The rule ID that uniquely identifies a verification rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The weak content algorithm name: md5 or crc32.</para>
            /// 
            /// <b>Example:</b>
            /// <para>md5</para>
            /// </summary>
            [NameInMap("weakContentAlgorithm")]
            [Validation(Required=false)]
            public string WeakContentAlgorithm { get; set; }

        }

    }

}
