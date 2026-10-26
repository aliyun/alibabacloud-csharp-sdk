// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateDataDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>The configuration content of the data modeling diagnostic task.</para>
        /// <list type="bullet">
        /// <item><description><para>If Type is set to ChangeRate, the configuration must include: analysis field (AnalysisField) and partition field format (PartitionFieldFormat).</para>
        /// </description></item>
        /// <item><description><para>If Type is set to PreferenceStatisticsCycle, the configuration must include: user ID field (UserIdField), single-day retention rate statistical period (RemainDays), ever-appeared rate statistical period (EverAppearedDays), periodic retention rate statistical period (RemainRatePeriods), and partition field format (PartitionFieldFormat).</para>
        /// </description></item>
        /// <item><description><para>If Type is set to JoinTables, the configuration must include: left table analysis field (LeftTableAnalysisField), right table analysis field (RightTableAnalysisField), left table JOIN field (LeftJoinField), right table JOIN field (RightJoinField), display sample quantity (SampleQuantity), left table partition field format (LeftTablePartitionFieldFormat), and right table partition field format (RightTablePartitionFieldFormat).</para>
        /// </description></item>
        /// <item><description><para>If Type is set to BaseStatistics, the configuration must include: tag field (TagField), tag field separator (TagFieldSeparator), KV field (KVField), KV field separator (KVFieldSeparator), KV pair separator (KVPairSeparator), text field (TextField), data percentile distribution (Quantiles), default value for string type (DefaultValueOfString), null string field for string type (NullStringField), and partition field format (PartitionFieldFormat).</para>
        /// </description></item>
        /// <item><description><para>If Type is set to AbnormalBehavior, the configuration must include: user ID field (UserId), item ID field (ItemId), behavior field (EventField), upstream behavior value (UpStreamBehavior), downstream behavior value (DownstreamBehavior), number of histogram bins (NumericHistogramBins), and partition field format (PartitionFieldFormat).</para>
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
        /// <para>The periodic run time. If this field is empty, the task does not run periodically. The format is HH:mm.</para>
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
        /// <para>The name of the data modeling diagnostic task configuration.</para>
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
        /// <para>The number of top N results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopNQuantity")]
        [Validation(Required=false)]
        public long? TopNQuantity { get; set; }

        /// <summary>
        /// <para>The type of the data diagnostic task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ChangeRate: item/user change rate analysis.</para>
        /// </description></item>
        /// <item><description><para>PreferenceStatisticsCycle: user preference statistical period analysis.</para>
        /// </description></item>
        /// <item><description><para>JoinTables: join table analysis.</para>
        /// </description></item>
        /// <item><description><para>BaseStatistics: basic statistics analysis.</para>
        /// </description></item>
        /// <item><description><para>AbnormalBehavior: abnormal behavior analysis.</para>
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
