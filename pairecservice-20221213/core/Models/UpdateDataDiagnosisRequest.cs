// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateDataDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the data diagnosis task, provided as a JSON string. The required fields vary based on the <c>Type</c> parameter. For <c>ChangeRate</c>, specify <c>AnalysisField</c> and <c>PartitionFieldFormat</c>. For <c>PreferenceStatisticsCycle</c>, specify <c>UserIdField</c>, <c>RemainDays</c>, <c>EverAppearedDays</c>, <c>RemainRatePeriods</c>, and <c>PartitionFieldFormat</c>. For <c>JoinTables</c>, specify <c>LeftTableAnalysisField</c>, <c>RightTableAnalysisField</c>, <c>LeftJoinField</c>, <c>RightJoinField</c>, <c>SampleQuantity</c>, <c>LeftTablePartitionFieldFormat</c>, and <c>RightTablePartitionFieldFormat</c>. For <c>BaseStatistics</c>, specify <c>TagField</c>, <c>TagFieldSeparator</c>, <c>KVField</c>, <c>KVFieldSeparator</c>, <c>KVPairSeparator</c>, <c>TextField</c>, <c>Quantiles</c>, <c>DefaultValueOfString</c>, <c>NullStringField</c>, and <c>PartitionFieldFormat</c>. For <c>AbnormalBehavior</c>, specify <c>UserId</c>, <c>ItemId</c>, <c>EventField</c>, <c>UpStreamBehavior</c>, <c>DownstreamBehavior</c>, <c>NumericHistogramBins</c>, and <c>PartitionFieldFormat</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AnalysisField&quot;:&quot;userid&quot;,&quot;PartitionFieldFormat&quot;:&quot;yyyymmdd&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The execution time for periodic runs. If this field is omitted, the task does not run periodically.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public string CycleTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the left data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LeftTableMetaId")]
        [Validation(Required=false)]
        public string LeftTableMetaId { get; set; }

        /// <summary>
        /// <para>The partition field of the left table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("LeftTablePartitionField")]
        [Validation(Required=false)]
        public string LeftTablePartitionField { get; set; }

        /// <summary>
        /// <para>The name of the data diagnosis task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_diagnosis_job1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The partition field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("PartitionField")]
        [Validation(Required=false)]
        public string PartitionField { get; set; }

        /// <summary>
        /// <para>The ID of the right data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RightTableMetaId")]
        [Validation(Required=false)]
        public string RightTableMetaId { get; set; }

        /// <summary>
        /// <para>The partition field of the right table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("RightTablePartitionField")]
        [Validation(Required=false)]
        public string RightTablePartitionField { get; set; }

        /// <summary>
        /// <para>The ID of the data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TableMetaId")]
        [Validation(Required=false)]
        public string TableMetaId { get; set; }

        /// <summary>
        /// <para>The number of top-ranked results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopNQuantity")]
        [Validation(Required=false)]
        public long? TopNQuantity { get; set; }

        /// <summary>
        /// <para>The type of the data diagnosis task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ChangeRate</c>: item/user change rate analysis.</para>
        /// </description></item>
        /// <item><description><para><c>PreferenceStatisticsCycle</c>: user preference statistics cycle analysis.</para>
        /// </description></item>
        /// <item><description><para><c>JoinTables</c>: two-table join analysis.</para>
        /// </description></item>
        /// <item><description><para><c>BaseStatistics</c>: basic statistical analysis.</para>
        /// </description></item>
        /// <item><description><para><c>AbnormalBehavior</c>: abnormal behavior analysis.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChangeRate</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
