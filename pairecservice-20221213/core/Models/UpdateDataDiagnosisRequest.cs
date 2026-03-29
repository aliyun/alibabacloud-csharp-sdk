// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateDataDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AnalysisField&quot;:&quot;userid&quot;,&quot;PartitionFieldFormat&quot;:&quot;yyyymmdd&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>08:00</para>
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public string CycleTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LeftTableMetaId")]
        [Validation(Required=false)]
        public string LeftTableMetaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("LeftTablePartitionField")]
        [Validation(Required=false)]
        public string LeftTablePartitionField { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_diagnosis_job1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("PartitionField")]
        [Validation(Required=false)]
        public string PartitionField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RightTableMetaId")]
        [Validation(Required=false)]
        public string RightTableMetaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("RightTablePartitionField")]
        [Validation(Required=false)]
        public string RightTablePartitionField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TableMetaId")]
        [Validation(Required=false)]
        public string TableMetaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopNQuantity")]
        [Validation(Required=false)]
        public long? TopNQuantity { get; set; }

        /// <summary>
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
