// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescirbeWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the workflow was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-15 16:30:25 +0800 CST</para>
        /// </summary>
        [NameInMap("create_time")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The duration of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1h15m33.529968361s</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0001-01-01 00:00:00 +0000 UTC</para>
        /// </summary>
        [NameInMap("finish_time")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The size of the input data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("input_data_size")]
        [Validation(Required=false)]
        public string InputDataSize { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wgs-gpu-97xfn</para>
        /// </summary>
        [NameInMap("job_name")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The namespace to which the workflow belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1171330362041663</para>
        /// </summary>
        [NameInMap("job_namespace")]
        [Validation(Required=false)]
        public string JobNamespace { get; set; }

        /// <summary>
        /// <para>The size of the output data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("output_data_size")]
        [Validation(Required=false)]
        public string OutputDataSize { get; set; }

        /// <summary>
        /// <para>The current state of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of base pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("total_bases")]
        [Validation(Required=false)]
        public string TotalBases { get; set; }

        /// <summary>
        /// <para>The number of reads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("total_reads")]
        [Validation(Required=false)]
        public string TotalReads { get; set; }

        /// <summary>
        /// <para>The user input parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;wgs_oss_region\&quot;:\&quot;cn-shenzhen\&quot;,\&quot;wgs_fastq_first_name\&quot;:\&quot;fastq/huada/MGISEQ-200019SZ0002402\&quot;,\&quot;wgs_fastq_second_name\&quot;:\&quot;fastq/huada/MGISEQ-200019SZ0002402\&quot;,\&quot;wgs_bucket_name\&quot;:\&quot;gene-shenzhen\&quot;,\&quot;wgs_vcf_file_name\&quot;:\&quot;output/vcf/huada.vcf\&quot;,\&quot;wgs_bam_file_name\&quot;:\&quot;output/bam/huada.bam\&quot;,\&quot;wgs_reference_file\&quot;:\&quot;hg19\&quot;,\&quot;wgs_service\&quot;:\&quot;g\&quot;}</para>
        /// </summary>
        [NameInMap("user_input_data")]
        [Validation(Required=false)]
        public string UserInputData { get; set; }

    }

}
