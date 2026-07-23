// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetDataDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the data diagnosis task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AnalysisField&quot;:&quot;userid&quot;,&quot;PartitionFieldFormat&quot;:&quot;yyyymmdd&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The time for periodic execution. If this field is empty, the task does not execute periodically.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public string CycleTime { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
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
        /// <para>The partition field of the left data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("LeftTablePartitionField")]
        [Validation(Required=false)]
        public string LeftTablePartitionField { get; set; }

        /// <summary>
        /// <para>The name of the data diagnosis task.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The partition field of the right data table.</para>
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
        /// <para>The name of the data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_meta_1</para>
        /// </summary>
        [NameInMap("TableMetaName")]
        [Validation(Required=false)]
        public string TableMetaName { get; set; }

        /// <summary>
        /// <para>The Top-N quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopNQuantity")]
        [Validation(Required=false)]
        public long? TopNQuantity { get; set; }

        /// <summary>
        /// <para>The type of the data diagnosis task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChangeRate</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
