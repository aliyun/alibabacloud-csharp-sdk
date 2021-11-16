// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StartWorkflowRequest : TeaModel {
        /// <summary>
        /// bam文件输出名称。
        /// </summary>
        [NameInMap("mapping_bam_out_filename")]
        [Validation(Required=false)]
        public string MappingBamOutFilename { get; set; }

        /// <summary>
        /// bam文件输出路径。
        /// </summary>
        [NameInMap("mapping_bam_out_path")]
        [Validation(Required=false)]
        public string MappingBamOutPath { get; set; }

        /// <summary>
        /// 存放mapping的bucket名称。
        /// </summary>
        [NameInMap("mapping_bucket_name")]
        [Validation(Required=false)]
        public string MappingBucketName { get; set; }

        /// <summary>
        /// mapping的第一个fastq文件名。
        /// </summary>
        [NameInMap("mapping_fastq_first_filename")]
        [Validation(Required=false)]
        public string MappingFastqFirstFilename { get; set; }

        /// <summary>
        /// mapping的fastq文件路径。
        /// </summary>
        [NameInMap("mapping_fastq_path")]
        [Validation(Required=false)]
        public string MappingFastqPath { get; set; }

        /// <summary>
        /// mapping的第二个fastq文件名。
        /// </summary>
        [NameInMap("mapping_fastq_second_filename")]
        [Validation(Required=false)]
        public string MappingFastqSecondFilename { get; set; }

        /// <summary>
        /// 是否进行dup。
        /// </summary>
        [NameInMap("mapping_is_mark_dup")]
        [Validation(Required=false)]
        public string MappingIsMarkDup { get; set; }

        /// <summary>
        /// mapping oss数据的存放region。
        /// </summary>
        [NameInMap("mapping_oss_region")]
        [Validation(Required=false)]
        public string MappingOssRegion { get; set; }

        /// <summary>
        /// mapping的reference文件位置。
        /// </summary>
        [NameInMap("mapping_reference_path")]
        [Validation(Required=false)]
        public string MappingReferencePath { get; set; }

        /// <summary>
        /// SLA类型，可选值：s、g、p。 白银级（s）：超过90 Gbp的部分，按1.5 Gbp/min计算增加的时间。 黄金级（g）：超过90 Gbp的部分，按2 Gbp/min计算增加的时间。 铂金级（p）：超过90 Gbp的部分，按3 Gbp/min计算增加的时间。
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// 存放wgs的bucket名称。
        /// </summary>
        [NameInMap("wgs_bucket_name")]
        [Validation(Required=false)]
        public string WgsBucketName { get; set; }

        /// <summary>
        /// wgs的第一个fastq文件名。
        /// </summary>
        [NameInMap("wgs_fastq_first_filename")]
        [Validation(Required=false)]
        public string WgsFastqFirstFilename { get; set; }

        /// <summary>
        /// wgs的fastq文件路径。
        /// </summary>
        [NameInMap("wgs_fastq_path")]
        [Validation(Required=false)]
        public string WgsFastqPath { get; set; }

        /// <summary>
        /// wgs的第二个fastq文件名。
        /// </summary>
        [NameInMap("wgs_fastq_second_filename")]
        [Validation(Required=false)]
        public string WgsFastqSecondFilename { get; set; }

        /// <summary>
        /// wgs oss数据的存放region。
        /// </summary>
        [NameInMap("wgs_oss_region")]
        [Validation(Required=false)]
        public string WgsOssRegion { get; set; }

        /// <summary>
        /// wgs的reference文件路径。
        /// </summary>
        [NameInMap("wgs_reference_path")]
        [Validation(Required=false)]
        public string WgsReferencePath { get; set; }

        /// <summary>
        /// wgs的vcf输出文件名称。
        /// </summary>
        [NameInMap("wgs_vcf_out_filename")]
        [Validation(Required=false)]
        public string WgsVcfOutFilename { get; set; }

        /// <summary>
        /// wgs的vcf输出路径。
        /// </summary>
        [NameInMap("wgs_vcf_out_path")]
        [Validation(Required=false)]
        public string WgsVcfOutPath { get; set; }

        /// <summary>
        /// 工作流类型，可选值：wgs或mapping。
        /// </summary>
        [NameInMap("workflow_type")]
        [Validation(Required=false)]
        public string WorkflowType { get; set; }

    }

}
