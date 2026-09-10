// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class UpdateDataCheckTemplateRequest : TeaModel {
        [NameInMap("basicMetricRules")]
        [Validation(Required=false)]
        public List<UpdateDataCheckTemplateRequestBasicMetricRules> BasicMetricRules { get; set; }
        public class UpdateDataCheckTemplateRequestBasicMetricRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SUM,AVG</para>
            /// </summary>
            [NameInMap("checkMethods")]
            [Validation(Required=false)]
            public string CheckMethods { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("controlFloatPrecision")]
            [Validation(Required=false)]
            public int? ControlFloatPrecision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeClassify")]
            [Validation(Required=false)]
            public int? DataTypeClassify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            [NameInMap("dataTypeList")]
            [Validation(Required=false)]
            public List<string> DataTypeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("dataTypes")]
            [Validation(Required=false)]
            public string DataTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("diffTolerateType")]
            [Validation(Required=false)]
            public int? DiffTolerateType { get; set; }

            [NameInMap("diffTolerateValues")]
            [Validation(Required=false)]
            public Dictionary<string, object> DiffTolerateValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("enableDecimalScale")]
            [Validation(Required=false)]
            public int? EnableDecimalScale { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumnName")]
            [Validation(Required=false)]
            public string FilterColumnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumns")]
            [Validation(Required=false)]
            public string FilterColumns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floatPrecision")]
            [Validation(Required=false)]
            public int? FloatPrecision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalDiff")]
            [Validation(Required=false)]
            public int? IgnoreDecimalDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalScaleSuffixZero")]
            [Validation(Required=false)]
            public int? IgnoreDecimalScaleSuffixZero { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreEmptyDiff")]
            [Validation(Required=false)]
            public int? IgnoreEmptyDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreNumericZero")]
            [Validation(Required=false)]
            public int? IgnoreNumericZero { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreStringEmpty")]
            [Validation(Required=false)]
            public int? IgnoreStringEmpty { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreZeroDiff")]
            [Validation(Required=false)]
            public int? IgnoreZeroDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isCountCheck")]
            [Validation(Required=false)]
            public int? IsCountCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("setDecimalScale")]
            [Validation(Required=false)]
            public int? SetDecimalScale { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("checkType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        [NameInMap("complexMetricRules")]
        [Validation(Required=false)]
        public List<UpdateDataCheckTemplateRequestComplexMetricRules> ComplexMetricRules { get; set; }
        public class UpdateDataCheckTemplateRequestComplexMetricRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SUM,AVG</para>
            /// </summary>
            [NameInMap("checkMethods")]
            [Validation(Required=false)]
            public string CheckMethods { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("controlFloatPrecision")]
            [Validation(Required=false)]
            public int? ControlFloatPrecision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeClassify")]
            [Validation(Required=false)]
            public int? DataTypeClassify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            [NameInMap("dataTypeList")]
            [Validation(Required=false)]
            public List<string> DataTypeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("dataTypes")]
            [Validation(Required=false)]
            public string DataTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("diffTolerateType")]
            [Validation(Required=false)]
            public int? DiffTolerateType { get; set; }

            [NameInMap("diffTolerateValues")]
            [Validation(Required=false)]
            public Dictionary<string, object> DiffTolerateValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("enableDecimalScale")]
            [Validation(Required=false)]
            public int? EnableDecimalScale { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumnName")]
            [Validation(Required=false)]
            public string FilterColumnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumns")]
            [Validation(Required=false)]
            public string FilterColumns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floatPrecision")]
            [Validation(Required=false)]
            public int? FloatPrecision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalDiff")]
            [Validation(Required=false)]
            public int? IgnoreDecimalDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalScaleSuffixZero")]
            [Validation(Required=false)]
            public int? IgnoreDecimalScaleSuffixZero { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreEmptyDiff")]
            [Validation(Required=false)]
            public int? IgnoreEmptyDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreNumericZero")]
            [Validation(Required=false)]
            public int? IgnoreNumericZero { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreStringEmpty")]
            [Validation(Required=false)]
            public int? IgnoreStringEmpty { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreZeroDiff")]
            [Validation(Required=false)]
            public int? IgnoreZeroDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isCountCheck")]
            [Validation(Required=false)]
            public int? IsCountCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("setDecimalScale")]
            [Validation(Required=false)]
            public int? SetDecimalScale { get; set; }

        }

        [NameInMap("dsEngineRels")]
        [Validation(Required=false)]
        public List<UpdateDataCheckTemplateRequestDsEngineRels> DsEngineRels { get; set; }
        public class UpdateDataCheckTemplateRequestDsEngineRels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("dsEngineId")]
            [Validation(Required=false)]
            public string DsEngineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("dsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }

            [NameInMap("engineTypes")]
            [Validation(Required=false)]
            public List<string> EngineTypes { get; set; }

        }

        [NameInMap("fulltextRule")]
        [Validation(Required=false)]
        public UpdateDataCheckTemplateRequestFulltextRule FulltextRule { get; set; }
        public class UpdateDataCheckTemplateRequestFulltextRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("checkMode")]
            [Validation(Required=false)]
            public int? CheckMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnEqualCmpType")]
            [Validation(Required=false)]
            public int? ColumnEqualCmpType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ARRAY,MAP</para>
            /// </summary>
            [NameInMap("columnEqualCmpValues")]
            [Validation(Required=false)]
            public string ColumnEqualCmpValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsCosine")]
            [Validation(Required=false)]
            public int? ColumnIsCosine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsIgnoreNull")]
            [Validation(Required=false)]
            public int? ColumnIsIgnoreNull { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsIgnoreZero")]
            [Validation(Required=false)]
            public int? ColumnIsIgnoreZero { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnIsSamples")]
            [Validation(Required=false)]
            public int? ColumnIsSamples { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnSamplesType")]
            [Validation(Required=false)]
            public int? ColumnSamplesType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("columnSamplesValue")]
            [Validation(Required=false)]
            public int? ColumnSamplesValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("columnSizeCmpType")]
            [Validation(Required=false)]
            public int? ColumnSizeCmpType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ARRAY,MAP</para>
            /// </summary>
            [NameInMap("columnSizeCmpValues")]
            [Validation(Required=false)]
            public string ColumnSizeCmpValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isPrimaryKeyCheck")]
            [Validation(Required=false)]
            public int? IsPrimaryKeyCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineCheckType")]
            [Validation(Required=false)]
            public int? LineCheckType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineIsPrintAll")]
            [Validation(Required=false)]
            public int? LineIsPrintAll { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineIsSamples")]
            [Validation(Required=false)]
            public int? LineIsSamples { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lineSamplesType")]
            [Validation(Required=false)]
            public int? LineSamplesType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("lineSamplesValue")]
            [Validation(Required=false)]
            public int? LineSamplesValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        [NameInMap("metricRules")]
        [Validation(Required=false)]
        public List<UpdateDataCheckTemplateRequestMetricRules> MetricRules { get; set; }
        public class UpdateDataCheckTemplateRequestMetricRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SUM,AVG</para>
            /// </summary>
            [NameInMap("checkMethods")]
            [Validation(Required=false)]
            public string CheckMethods { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("controlFloatPrecision")]
            [Validation(Required=false)]
            public int? ControlFloatPrecision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeClassify")]
            [Validation(Required=false)]
            public int? DataTypeClassify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            [NameInMap("dataTypeList")]
            [Validation(Required=false)]
            public List<string> DataTypeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("dataTypes")]
            [Validation(Required=false)]
            public string DataTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("diffTolerateType")]
            [Validation(Required=false)]
            public int? DiffTolerateType { get; set; }

            [NameInMap("diffTolerateValues")]
            [Validation(Required=false)]
            public Dictionary<string, object> DiffTolerateValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("enableDecimalScale")]
            [Validation(Required=false)]
            public int? EnableDecimalScale { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumnName")]
            [Validation(Required=false)]
            public string FilterColumnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("filterColumns")]
            [Validation(Required=false)]
            public string FilterColumns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("floatPrecision")]
            [Validation(Required=false)]
            public int? FloatPrecision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalDiff")]
            [Validation(Required=false)]
            public int? IgnoreDecimalDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreDecimalScaleSuffixZero")]
            [Validation(Required=false)]
            public int? IgnoreDecimalScaleSuffixZero { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreEmptyDiff")]
            [Validation(Required=false)]
            public int? IgnoreEmptyDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreNumericZero")]
            [Validation(Required=false)]
            public int? IgnoreNumericZero { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreStringEmpty")]
            [Validation(Required=false)]
            public int? IgnoreStringEmpty { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ignoreZeroDiff")]
            [Validation(Required=false)]
            public int? IgnoreZeroDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isCountCheck")]
            [Validation(Required=false)]
            public int? IsCountCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("setDecimalScale")]
            [Validation(Required=false)]
            public int? SetDecimalScale { get; set; }

        }

        [NameInMap("nullRules")]
        [Validation(Required=false)]
        public List<UpdateDataCheckTemplateRequestNullRules> NullRules { get; set; }
        public class UpdateDataCheckTemplateRequestNullRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("dataTypeGroup")]
            [Validation(Required=false)]
            public int? DataTypeGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("nullValues")]
            [Validation(Required=false)]
            public string NullValues { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>数据量校验模板描述</para>
        /// </summary>
        [NameInMap("templateDesc")]
        [Validation(Required=false)]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>数据量校验模板</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("weakContentRule")]
        [Validation(Required=false)]
        public UpdateDataCheckTemplateRequestWeakContentRule WeakContentRule { get; set; }
        public class UpdateDataCheckTemplateRequestWeakContentRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>^col_.*$</para>
            /// </summary>
            [NameInMap("filterColumnExpression")]
            [Validation(Required=false)]
            public string FilterColumnExpression { get; set; }

            [NameInMap("filterColumnTypes")]
            [Validation(Required=false)]
            public List<string> FilterColumnTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>md5</para>
            /// </summary>
            [NameInMap("weakContentAlgorithm")]
            [Validation(Required=false)]
            public string WeakContentAlgorithm { get; set; }

        }

    }

}
