// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListDataDiagnosisReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The exception report list.</para>
        /// </summary>
        [NameInMap("ExceptionRate")]
        [Validation(Required=false)]
        public List<ListDataDiagnosisReportsResponseBodyExceptionRate> ExceptionRate { get; set; }
        public class ListDataDiagnosisReportsResponseBodyExceptionRate : TeaModel {
            /// <summary>
            /// <para>The exception group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The exception message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>change_rate 大于 0.2，请确认是否正常</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The type or level of the exception.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WARN</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Reports for the abnormal behavior analysis task.</para>
        /// </summary>
        [NameInMap("ReportsOfAbnormalBehavior")]
        [Validation(Required=false)]
        public List<List<ListDataDiagnosisReportsResponseBodyReportsOfAbnormalBehavior>> ReportsOfAbnormalBehavior { get; set; }
        public class ListDataDiagnosisReportsResponseBodyReportsOfAbnormalBehavior : TeaModel {
            /// <summary>
            /// <para>The date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250114</para>
            /// </summary>
            [NameInMap("Ds")]
            [Validation(Required=false)]
            public string Ds { get; set; }

            /// <summary>
            /// <para>The rank.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RankId")]
            [Validation(Required=false)]
            public string RankId { get; set; }

            /// <summary>
            /// <para>The conversion rate from upstream behavior to downstream behavior.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("ConversionRate")]
            [Validation(Required=false)]
            public string ConversionRate { get; set; }

            /// <summary>
            /// <para>The ID corresponding to the statistical granularity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100010050+259203779</para>
            /// </summary>
            [NameInMap("ConversionRateIds")]
            [Validation(Required=false)]
            public string ConversionRateIds { get; set; }

            /// <summary>
            /// <para>The count of downstream behaviors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("DownStreamCount")]
            [Validation(Required=false)]
            public string DownStreamCount { get; set; }

            /// <summary>
            /// <para>The ID corresponding to the granularity of the downstream behavior.</para>
            /// 
            /// <b>Example:</b>
            /// <para>189814043+272292277</para>
            /// </summary>
            [NameInMap("DownStreamCountIds")]
            [Validation(Required=false)]
            public string DownStreamCountIds { get; set; }

            /// <summary>
            /// <para>The statistical granularity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pair</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>The count of upstream behaviors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("UpStreamCount")]
            [Validation(Required=false)]
            public string UpStreamCount { get; set; }

            /// <summary>
            /// <para>The ID corresponding to the granularity of the upstream behavior.</para>
            /// 
            /// <b>Example:</b>
            /// <para>104684044+249445882</para>
            /// </summary>
            [NameInMap("UpStreamCountIds")]
            [Validation(Required=false)]
            public string UpStreamCountIds { get; set; }

            /// <summary>
            /// <para>The feature distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{678.8225: 91, 5270.4675: 95}</para>
            /// </summary>
            [NameInMap("Distribution")]
            [Validation(Required=false)]
            public string Distribution { get; set; }

            /// <summary>
            /// <para>The indicator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conversion_rate</para>
            /// </summary>
            [NameInMap("IndicatorName")]
            [Validation(Required=false)]
            public string IndicatorName { get; set; }

            /// <summary>
            /// <para>The exception rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("ExceptionRate")]
            [Validation(Required=false)]
            public string ExceptionRate { get; set; }

        }

        /// <summary>
        /// <para>Reports for the basic statistical analysis task.</para>
        /// </summary>
        [NameInMap("ReportsOfBaseStatistics")]
        [Validation(Required=false)]
        public List<List<ListDataDiagnosisReportsResponseBodyReportsOfBaseStatistics>> ReportsOfBaseStatistics { get; set; }
        public class ListDataDiagnosisReportsResponseBodyReportsOfBaseStatistics : TeaModel {
            /// <summary>
            /// <para>The equivalent null count. This refers to the count of specific characters, such as <c>\\N</c>, that are treated as null values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\\N</para>
            /// </summary>
            [NameInMap("DefaultNullCount")]
            [Validation(Required=false)]
            public string DefaultNullCount { get; set; }

            /// <summary>
            /// <para>The equivalent null rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\\N</para>
            /// </summary>
            [NameInMap("DefaultNullRate")]
            [Validation(Required=false)]
            public string DefaultNullRate { get; set; }

            /// <summary>
            /// <para>The date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230509</para>
            /// </summary>
            [NameInMap("Ds")]
            [Validation(Required=false)]
            public string Ds { get; set; }

            /// <summary>
            /// <para>The feature name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>register_time</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>The feature type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("FeatureType")]
            [Validation(Required=false)]
            public string FeatureType { get; set; }

            /// <summary>
            /// <para>The null count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55095</para>
            /// </summary>
            [NameInMap("NullCount")]
            [Validation(Required=false)]
            public string NullCount { get; set; }

            /// <summary>
            /// <para>The null rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5580879448141732</para>
            /// </summary>
            [NameInMap("NullRate")]
            [Validation(Required=false)]
            public string NullRate { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98721</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

            /// <summary>
            /// <para>The number of unique values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29</para>
            /// </summary>
            [NameInMap("UniqueCount")]
            [Validation(Required=false)]
            public string UniqueCount { get; set; }

            /// <summary>
            /// <para>The maximum value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52.0</para>
            /// </summary>
            [NameInMap("ValueMax")]
            [Validation(Required=false)]
            public string ValueMax { get; set; }

            /// <summary>
            /// <para>The median value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35.0</para>
            /// </summary>
            [NameInMap("ValueMedian")]
            [Validation(Required=false)]
            public string ValueMedian { get; set; }

            /// <summary>
            /// <para>The minimum value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.0</para>
            /// </summary>
            [NameInMap("ValueMin")]
            [Validation(Required=false)]
            public string ValueMin { get; set; }

            /// <summary>
            /// <para>The 1st percentile value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.0</para>
            /// </summary>
            [NameInMap("ValueQuantile1")]
            [Validation(Required=false)]
            public string ValueQuantile1 { get; set; }

            /// <summary>
            /// <para>The 5th percentile value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.0</para>
            /// </summary>
            [NameInMap("ValueQuantile5")]
            [Validation(Required=false)]
            public string ValueQuantile5 { get; set; }

            /// <summary>
            /// <para>The 25th percentile value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.0</para>
            /// </summary>
            [NameInMap("ValueQuantile25")]
            [Validation(Required=false)]
            public string ValueQuantile25 { get; set; }

            /// <summary>
            /// <para>The 75th percentile value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.0</para>
            /// </summary>
            [NameInMap("ValueQuantile75")]
            [Validation(Required=false)]
            public string ValueQuantile75 { get; set; }

            /// <summary>
            /// <para>The 95th percentile value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.0</para>
            /// </summary>
            [NameInMap("ValueQuantile95")]
            [Validation(Required=false)]
            public string ValueQuantile95 { get; set; }

            /// <summary>
            /// <para>The 99th percentile value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.0</para>
            /// </summary>
            [NameInMap("ValueQuantile99")]
            [Validation(Required=false)]
            public string ValueQuantile99 { get; set; }

            /// <summary>
            /// <para>The rank.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Rn")]
            [Validation(Required=false)]
            public string Rn { get; set; }

            /// <summary>
            /// <para>The maximum frequency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91149.0</para>
            /// </summary>
            [NameInMap("FrequencyMax")]
            [Validation(Required=false)]
            public string FrequencyMax { get; set; }

            /// <summary>
            /// <para>The median frequency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1349.0</para>
            /// </summary>
            [NameInMap("FrequencyMedian")]
            [Validation(Required=false)]
            public string FrequencyMedian { get; set; }

            /// <summary>
            /// <para>The minimum frequency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>289.0</para>
            /// </summary>
            [NameInMap("FrequencyMin")]
            [Validation(Required=false)]
            public string FrequencyMin { get; set; }

            /// <summary>
            /// <para>The 1st frequency percentile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>289.0</para>
            /// </summary>
            [NameInMap("FrequencyQuantile1")]
            [Validation(Required=false)]
            public string FrequencyQuantile1 { get; set; }

            /// <summary>
            /// <para>The 5th frequency percentile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>289.0</para>
            /// </summary>
            [NameInMap("FrequencyQuantile5")]
            [Validation(Required=false)]
            public string FrequencyQuantile5 { get; set; }

            /// <summary>
            /// <para>The 25th frequency percentile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>289.0</para>
            /// </summary>
            [NameInMap("FrequencyQuantile25")]
            [Validation(Required=false)]
            public string FrequencyQuantile25 { get; set; }

            /// <summary>
            /// <para>The 75th frequency percentile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>289.0</para>
            /// </summary>
            [NameInMap("FrequencyQuantile75")]
            [Validation(Required=false)]
            public string FrequencyQuantile75 { get; set; }

            /// <summary>
            /// <para>The 95th frequency percentile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>289.0</para>
            /// </summary>
            [NameInMap("FrequencyQuantile95")]
            [Validation(Required=false)]
            public string FrequencyQuantile95 { get; set; }

            /// <summary>
            /// <para>The 99th frequency percentile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>289.0</para>
            /// </summary>
            [NameInMap("FrequencyQuantile99")]
            [Validation(Required=false)]
            public string FrequencyQuantile99 { get; set; }

            /// <summary>
            /// <para>The feature distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{678.8225: 91, 5270.4675: 95}</para>
            /// </summary>
            [NameInMap("Distribution")]
            [Validation(Required=false)]
            public string Distribution { get; set; }

            /// <summary>
            /// <para>The rank of the statistical indicator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RankId")]
            [Validation(Required=false)]
            public string RankId { get; set; }

            /// <summary>
            /// <para>The feature value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683562246</para>
            /// </summary>
            [NameInMap("FeatureValue")]
            [Validation(Required=false)]
            public string FeatureValue { get; set; }

            /// <summary>
            /// <para>The value count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ValueCount")]
            [Validation(Required=false)]
            public string ValueCount { get; set; }

            /// <summary>
            /// <para>The value percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.000019996000799840032</para>
            /// </summary>
            [NameInMap("ValuePercent")]
            [Validation(Required=false)]
            public string ValuePercent { get; set; }

            /// <summary>
            /// <para>The value quantile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.7261657444926671</para>
            /// </summary>
            [NameInMap("ValueQuantile")]
            [Validation(Required=false)]
            public string ValueQuantile { get; set; }

            /// <summary>
            /// <para>The frequency of the feature value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>427</para>
            /// </summary>
            [NameInMap("FeatureFrequency")]
            [Validation(Required=false)]
            public string FeatureFrequency { get; set; }

            /// <summary>
            /// <para>The number of feature values with this frequency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FrequencyCount")]
            [Validation(Required=false)]
            public string FrequencyCount { get; set; }

            /// <summary>
            /// <para>The percentage of feature values with this frequency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("FrequencyPercent")]
            [Validation(Required=false)]
            public string FrequencyPercent { get; set; }

            /// <summary>
            /// <para>The percentile of the frequency of field values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FrequencyQuantile")]
            [Validation(Required=false)]
            public string FrequencyQuantile { get; set; }

        }

        /// <summary>
        /// <para>Reports for the item/user change rate analysis task.</para>
        /// </summary>
        [NameInMap("ReportsOfChangeRateData")]
        [Validation(Required=false)]
        public List<List<ListDataDiagnosisReportsResponseBodyReportsOfChangeRateData>> ReportsOfChangeRateData { get; set; }
        public class ListDataDiagnosisReportsResponseBodyReportsOfChangeRateData : TeaModel {
            /// <summary>
            /// <para>The date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230509</para>
            /// </summary>
            [NameInMap("Ds")]
            [Validation(Required=false)]
            public string Ds { get; set; }

            /// <summary>
            /// <para>A flag that indicates the type of change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The item/user change count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("ChangeCount")]
            [Validation(Required=false)]
            public string ChangeCount { get; set; }

            /// <summary>
            /// <para>The item/user change rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1231</para>
            /// </summary>
            [NameInMap("ChangeRate")]
            [Validation(Required=false)]
            public string ChangeRate { get; set; }

        }

        /// <summary>
        /// <para>Reports for the table join analysis task.</para>
        /// </summary>
        [NameInMap("ReportsOfJoinTables")]
        [Validation(Required=false)]
        public List<List<ListDataDiagnosisReportsResponseBodyReportsOfJoinTables>> ReportsOfJoinTables { get; set; }
        public class ListDataDiagnosisReportsResponseBodyReportsOfJoinTables : TeaModel {
            /// <summary>
            /// <para>The date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230509</para>
            /// </summary>
            [NameInMap("Ds")]
            [Validation(Required=false)]
            public string Ds { get; set; }

            /// <summary>
            /// <para>The join field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_id</para>
            /// </summary>
            [NameInMap("JoinField")]
            [Validation(Required=false)]
            public string JoinField { get; set; }

            /// <summary>
            /// <para>The left table join exception rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.53</para>
            /// </summary>
            [NameInMap("LeftExceptRate")]
            [Validation(Required=false)]
            public string LeftExceptRate { get; set; }

            /// <summary>
            /// <para>The right table join exception rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("RightExceptRate")]
            [Validation(Required=false)]
            public string RightExceptRate { get; set; }

            /// <summary>
            /// <para>A flag that indicates the type of change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// <para>The feature name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>register_time</para>
            /// </summary>
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            /// <summary>
            /// <para>The feature value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683562246</para>
            /// </summary>
            [NameInMap("FeatureValue")]
            [Validation(Required=false)]
            public string FeatureValue { get; set; }

            /// <summary>
            /// <para>The feature percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The quantile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Quantile")]
            [Validation(Required=false)]
            public string Quantile { get; set; }

            /// <summary>
            /// <para>The value count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ValueCount")]
            [Validation(Required=false)]
            public string ValueCount { get; set; }

            /// <summary>
            /// <para>The value percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.019996000799</para>
            /// </summary>
            [NameInMap("ValuePercent")]
            [Validation(Required=false)]
            public string ValuePercent { get; set; }

            /// <summary>
            /// <para>The value quantile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.72616</para>
            /// </summary>
            [NameInMap("ValueQuantile")]
            [Validation(Required=false)]
            public string ValueQuantile { get; set; }

        }

        /// <summary>
        /// <para>Reports for the user preference statistics cycle analysis task.</para>
        /// </summary>
        [NameInMap("ReportsOfPreferenceStatisticsCycle")]
        [Validation(Required=false)]
        public List<List<ListDataDiagnosisReportsResponseBodyReportsOfPreferenceStatisticsCycle>> ReportsOfPreferenceStatisticsCycle { get; set; }
        public class ListDataDiagnosisReportsResponseBodyReportsOfPreferenceStatisticsCycle : TeaModel {
            /// <summary>
            /// <para>The periodic user retention rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.73</para>
            /// </summary>
            [NameInMap("CycleRemainRate")]
            [Validation(Required=false)]
            public string CycleRemainRate { get; set; }

            /// <summary>
            /// <para>The daily user retention rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.52</para>
            /// </summary>
            [NameInMap("SingleRemainRate")]
            [Validation(Required=false)]
            public string SingleRemainRate { get; set; }

            /// <summary>
            /// <para>The date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230509</para>
            /// </summary>
            [NameInMap("Ds")]
            [Validation(Required=false)]
            public string Ds { get; set; }

            /// <summary>
            /// <para>The value of k for the k-day retention rate or k-day ever-appeared rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public string Days { get; set; }

            /// <summary>
            /// <para>The k-day ever-appeared rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.67</para>
            /// </summary>
            [NameInMap("EverAppearedRate")]
            [Validation(Required=false)]
            public string EverAppearedRate { get; set; }

            /// <summary>
            /// <para>The statistical period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>week</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The periodic retention rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.33</para>
            /// </summary>
            [NameInMap("PeriodRemainRate")]
            [Validation(Required=false)]
            public string PeriodRemainRate { get; set; }

            /// <summary>
            /// <para>The periodic retention count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodRemainCount")]
            [Validation(Required=false)]
            public long? PeriodRemainCount { get; set; }

            /// <summary>
            /// <para>The number of period intervals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodInternal")]
            [Validation(Required=false)]
            public long? PeriodInternal { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data diagnosis task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ChangeRate</c>: item/user change rate analysis.</para>
        /// </description></item>
        /// <item><description><para><c>PreferenceStatisticsCycle</c>: user preference statistics cycle analysis.</para>
        /// </description></item>
        /// <item><description><para><c>JoinTables</c>: table join analysis.</para>
        /// </description></item>
        /// <item><description><para><c>BaseStatistics</c>: basic statistical analysis.</para>
        /// </description></item>
        /// <item><description><para><c>AbnormalBehavior</c>: abnormal behavior analysis.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ChangeRate</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
