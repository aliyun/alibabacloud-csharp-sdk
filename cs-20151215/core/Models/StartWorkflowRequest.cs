// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StartWorkflowRequest : TeaModel {
        /// <summary>
        /// The name of the output BAM file.
        /// </summary>
        [NameInMap("mapping_bam_out_filename")]
        [Validation(Required=false)]
        public string MappingBamOutFilename { get; set; }

        /// <summary>
        /// The output path of the Binary Alignment Map (BAM) file.
        /// </summary>
        [NameInMap("mapping_bam_out_path")]
        [Validation(Required=false)]
        public string MappingBamOutPath { get; set; }

        /// <summary>
        /// The name of the OSS bucket that stores the data of the mapping workflow.
        /// </summary>
        [NameInMap("mapping_bucket_name")]
        [Validation(Required=false)]
        public string MappingBucketName { get; set; }

        /// <summary>
        /// The name of the first FASTQ file of the mapping workflow.
        /// </summary>
        [NameInMap("mapping_fastq_first_filename")]
        [Validation(Required=false)]
        public string MappingFastqFirstFilename { get; set; }

        /// <summary>
        /// The path of the FASTQ files of the mapping workflow.
        /// </summary>
        [NameInMap("mapping_fastq_path")]
        [Validation(Required=false)]
        public string MappingFastqPath { get; set; }

        /// <summary>
        /// The name of the second FASTQ file of the mapping workflow.
        /// </summary>
        [NameInMap("mapping_fastq_second_filename")]
        [Validation(Required=false)]
        public string MappingFastqSecondFilename { get; set; }

        /// <summary>
        /// Specifies whether to mark duplicate values.
        /// </summary>
        [NameInMap("mapping_is_mark_dup")]
        [Validation(Required=false)]
        public string MappingIsMarkDup { get; set; }

        /// <summary>
        /// The region where the Object Storage Service (OSS) bucket that stores the data of the mapping workflow is deployed.
        /// </summary>
        [NameInMap("mapping_oss_region")]
        [Validation(Required=false)]
        public string MappingOssRegion { get; set; }

        /// <summary>
        /// The path of the reference files of the mapping workflow.
        /// </summary>
        [NameInMap("mapping_reference_path")]
        [Validation(Required=false)]
        public string MappingReferencePath { get; set; }

        /// <summary>
        /// The type of service-level agreement (SLA). Valid values:
        /// 
        /// *   s: the silver level (S-level). It requires 1 extra minute to process every 1.5 billion base pairs beyond the limit of 90 billion base pairs.
        /// *   g: the gold level (G-level). It requires 1 extra minute to process every 2 billion base pairs beyond the limit of 90 billion base pairs.
        /// *   p: the platinum level (P-level). It requires 1 extra minute to process every 3 billion base pairs beyond the limit of 90 billion base pairs.
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// The name of the OSS bucket that stores the data of the WGS workflow.
        /// </summary>
        [NameInMap("wgs_bucket_name")]
        [Validation(Required=false)]
        public string WgsBucketName { get; set; }

        /// <summary>
        /// The name of the first FASTQ file of the WGS workflow.
        /// </summary>
        [NameInMap("wgs_fastq_first_filename")]
        [Validation(Required=false)]
        public string WgsFastqFirstFilename { get; set; }

        /// <summary>
        /// The path of the FASTQ files of the WGS workflow.
        /// </summary>
        [NameInMap("wgs_fastq_path")]
        [Validation(Required=false)]
        public string WgsFastqPath { get; set; }

        /// <summary>
        /// The name of the second FASTQ file of the WGS workflow.
        /// </summary>
        [NameInMap("wgs_fastq_second_filename")]
        [Validation(Required=false)]
        public string WgsFastqSecondFilename { get; set; }

        /// <summary>
        /// The region where the OSS bucket that stores the data of the whole genome sequencing (WGS) workflow is deployed.
        /// </summary>
        [NameInMap("wgs_oss_region")]
        [Validation(Required=false)]
        public string WgsOssRegion { get; set; }

        /// <summary>
        /// The path of the reference files of the WGS workflow.
        /// </summary>
        [NameInMap("wgs_reference_path")]
        [Validation(Required=false)]
        public string WgsReferencePath { get; set; }

        /// <summary>
        /// The name of the output VCF file.
        /// </summary>
        [NameInMap("wgs_vcf_out_filename")]
        [Validation(Required=false)]
        public string WgsVcfOutFilename { get; set; }

        /// <summary>
        /// The output path of the Variant Call Format (VCF) file.
        /// </summary>
        [NameInMap("wgs_vcf_out_path")]
        [Validation(Required=false)]
        public string WgsVcfOutPath { get; set; }

        /// <summary>
        /// The type of workflow. Valid values: wgs and mapping.
        /// </summary>
        [NameInMap("workflow_type")]
        [Validation(Required=false)]
        public string WorkflowType { get; set; }

    }

}
