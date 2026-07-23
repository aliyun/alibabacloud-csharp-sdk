// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListDataDiagnosesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data diagnoses.</para>
        /// </summary>
        [NameInMap("DataDiagnoses")]
        [Validation(Required=false)]
        public List<ListDataDiagnosesResponseBodyDataDiagnoses> DataDiagnoses { get; set; }
        public class ListDataDiagnosesResponseBodyDataDiagnoses : TeaModel {
            /// <summary>
            /// <para>The configuration for the data diagnosis task, in JSON format. The required fields depend on the <c>Type</c> value:<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AnalysisField&quot;: &quot;userid&quot;,&quot;PartitionFieldFormat&quot;: &quot;yyyymmdd&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The time at which the task is scheduled to run periodically. If this parameter is empty, the task runs only once.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The data diagnosis ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DataDiagnosisId")]
            [Validation(Required=false)]
            public string DataDiagnosisId { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the task was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

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
            /// <para>The name of the data diagnosis.</para>
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
            /// <para>The data table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TableMetaId")]
            [Validation(Required=false)]
            public string TableMetaId { get; set; }

            /// <summary>
            /// <para>The name of the data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_meta_1</para>
            /// </summary>
            [NameInMap("TableMetaName")]
            [Validation(Required=false)]
            public string TableMetaName { get; set; }

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
            /// <para>The type of data diagnosis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ChangeRate</c>: Change Rate Analysis.</para>
            /// </description></item>
            /// <item><description><para><c>PreferenceStatisticsCycle</c>: Preference Statistics Cycle Analysis.</para>
            /// </description></item>
            /// <item><description><para><c>JoinTables</c>: Join Tables Analysis.</para>
            /// </description></item>
            /// <item><description><para><c>BaseStatistics</c>: Base Statistics Analysis.</para>
            /// </description></item>
            /// <item><description><para><c>AbnormalBehavior</c>: Abnormal Behavior Analysis.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
