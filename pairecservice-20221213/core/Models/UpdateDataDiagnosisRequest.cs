// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateDataDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>The configuration details of the data diagnostic task. If <c>Type</c> is set to <c>ChangeRate</c>, include the analysis field (<c>AnalysisField</c>) and partition field format (<c>PartitionFieldFormat</c>). If <c>Type</c> is set to <c>PreferenceStatisticsCycle</c>, include the user ID field (<c>UserIdField</c>), single-day retention rate statistical period (<c>RemainDays</c>), appearance rate statistical period (<c>EverAppearedDays</c>), periodic retention rate statistical period (<c>RemainRatePeriods</c>), and partition field format (<c>PartitionFieldFormat</c>). If <c>Type</c> is set to <c>JoinTables</c>, include the left table analysis field (<c>LeftTableAnalysisField</c>), right table analysis field (<c>RightTableAnalysisField</c>), left table JOIN field (<c>LeftJoinField</c>), right table JOIN field (<c>RightJoinField</c>), sample quantity for display (<c>SampleQuantity</c>), left table partition field format (<c>LeftTablePartitionFieldFormat</c>), and right table partition field format (<c>RightTablePartitionFieldFormat</c>). If <c>Type</c> is set to <c>BaseStatistics</c>, include the Tag field (<c>TagField</c>), Tag field separator (<c>TagFieldSeparator</c>), KV field (<c>KVField</c>), KV field separator (<c>KVFieldSeparator</c>), KV pair separator (<c>KVPairSeparator</c>), Text field (<c>TextField</c>), data percentile distribution (<c>Quantiles</c>), default value for the string type (<c>DefaultValueOfString</c>), null value field for the string type (<c>NullStringField</c>), and partition field format (<c>PartitionFieldFormat</c>). If <c>Type</c> is set to <c>AbnormalBehavior</c>, include the user ID field (<c>UserId</c>), item ID field (<c>ItemId</c>), behavior field (<c>EventField</c>), upstream behavior value (<c>UpStreamBehavior</c>), downstream behavior value (<c>DownstreamBehavior</c>), number of buckets (<c>NumericHistogramBins</c>), and partition field format (<c>PartitionFieldFormat</c>).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AnalysisField&quot;:&quot;userid&quot;,&quot;PartitionFieldFormat&quot;:&quot;yyyymmdd&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The periodic execution time. If this field is left empty, the task does not run periodically. Format: HH:mm.</para>
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
        /// <para>The ID of the left table.</para>
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
        /// <para>The name of the data diagnostic task configuration.</para>
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
        /// <para>The ID of the right table.</para>
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
        /// <para>The Top N quantity.</para>
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
        /// <item><description>ChangeRate: item or user change rate analysis</description></item>
        /// <item><description>PreferenceStatisticsCycle: user preference statistical period analysis</description></item>
        /// <item><description>JoinTables: two-table association analysis</description></item>
        /// <item><description>BaseStatistics: basic statistical analysis</description></item>
        /// <item><description>AbnormalBehavior: abnormal behavior analysis</description></item>
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
