// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateDataDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for the data diagnosis task, specified as a JSON string. The required fields in this object depend on the value of the <c>Type</c> parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>Type</c> is set to <c>ChangeRate</c>, specify the following fields: <c>AnalysisField</c> and <c>PartitionFieldFormat</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>Type</c> is set to <c>PreferenceStatisticsCycle</c>, specify the following fields: <c>UserIdField</c>, <c>RemainDays</c>, <c>EverAppearedDays</c>, <c>RemainRatePeriods</c>, and <c>PartitionFieldFormat</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>Type</c> is set to <c>JoinTables</c>, specify the following fields: <c>LeftTableAnalysisField</c>, <c>RightTableAnalysisField</c>, <c>LeftJoinField</c>, <c>RightJoinField</c>, <c>SampleQuantity</c>, <c>LeftTablePartitionFieldFormat</c>, and <c>RightTablePartitionFieldFormat</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>Type</c> is set to <c>BaseStatistics</c>, specify the following fields: <c>TagField</c>, <c>TagFieldSeparator</c>, <c>KVField</c>, <c>KVFieldSeparator</c>, <c>KVPairSeparator</c>, <c>TextField</c>, <c>Quantiles</c>, <c>DefaultValueOfString</c>, <c>NullStringField</c>, and <c>PartitionFieldFormat</c>.</para>
        /// </description></item>
        /// <item><description><para>If <c>Type</c> is set to <c>AbnormalBehavior</c>, specify the following fields: <c>UserId</c>, <c>ItemId</c>, <c>EventField</c>, <c>UpStreamBehavior</c>, <c>DownstreamBehavior</c>, <c>NumericHistogramBins</c>, and <c>PartitionFieldFormat</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;AnalysisField&quot;: &quot;userid&quot;, &quot;PartitionFieldFormat&quot;: &quot;yyyymmdd&quot; }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The scheduled time to run the task. If this parameter is omitted, the task runs only once.</para>
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
        /// <para>The partition field for the left data table.</para>
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
        /// <para>The partition field for the right data table.</para>
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
        /// <para>The number of top results to return.</para>
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
        /// <item><description><para>ChangeRate: Item or user change rate analysis.</para>
        /// </description></item>
        /// <item><description><para>PreferenceStatisticsCycle: User preference statistics cycle analysis.</para>
        /// </description></item>
        /// <item><description><para>JoinTables: Two-table join analysis.</para>
        /// </description></item>
        /// <item><description><para>BaseStatistics: Basic statistical analysis.</para>
        /// </description></item>
        /// <item><description><para>AbnormalBehavior: Abnormal behavior analysis.</para>
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
