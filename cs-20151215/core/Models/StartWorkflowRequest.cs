// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StartWorkflowRequest : TeaModel {
        /// <summary>
        /// <para>The name of the output BAM file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc.bam</para>
        /// </summary>
        [NameInMap("mapping_bam_out_filename")]
        [Validation(Required=false)]
        public string MappingBamOutFilename { get; set; }

        /// <summary>
        /// <para>The output path of the Binary Alignment Map (BAM) file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>output/bamDirName</para>
        /// </summary>
        [NameInMap("mapping_bam_out_path")]
        [Validation(Required=false)]
        public string MappingBamOutPath { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket that stores the data of the mapping workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gene-shenzhen</para>
        /// </summary>
        [NameInMap("mapping_bucket_name")]
        [Validation(Required=false)]
        public string MappingBucketName { get; set; }

        /// <summary>
        /// <para>The name of the first FASTQ file of the mapping workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MGISEQ2000_PCR-free_NA12878_1_V100003043_L01_1.fq.gz</para>
        /// </summary>
        [NameInMap("mapping_fastq_first_filename")]
        [Validation(Required=false)]
        public string MappingFastqFirstFilename { get; set; }

        /// <summary>
        /// <para>The path of the FASTQ files of the mapping workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fastq/MGISEQ2000</para>
        /// </summary>
        [NameInMap("mapping_fastq_path")]
        [Validation(Required=false)]
        public string MappingFastqPath { get; set; }

        /// <summary>
        /// <para>The name of the second FASTQ file of the mapping workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MGISEQ2000_PCR-free_NA12878_1_V100003043_L01_2.fq.gz</para>
        /// </summary>
        [NameInMap("mapping_fastq_second_filename")]
        [Validation(Required=false)]
        public string MappingFastqSecondFilename { get; set; }

        /// <summary>
        /// <para>Specifies whether to mark duplicate values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("mapping_is_mark_dup")]
        [Validation(Required=false)]
        public string MappingIsMarkDup { get; set; }

        /// <summary>
        /// <para>The region where the Object Storage Service (OSS) bucket that stores the data of the mapping workflow is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("mapping_oss_region")]
        [Validation(Required=false)]
        public string MappingOssRegion { get; set; }

        /// <summary>
        /// <para>The path of the reference files of the mapping workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reference/hg19</para>
        /// </summary>
        [NameInMap("mapping_reference_path")]
        [Validation(Required=false)]
        public string MappingReferencePath { get; set; }

        /// <summary>
        /// <para>The type of service-level agreement (SLA). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>s: the silver level (S-level). It requires 1 extra minute to process every 1.5 billion base pairs beyond the limit of 90 billion base pairs.</description></item>
        /// <item><description>g: the gold level (G-level). It requires 1 extra minute to process every 2 billion base pairs beyond the limit of 90 billion base pairs.</description></item>
        /// <item><description>p: the platinum level (P-level). It requires 1 extra minute to process every 3 billion base pairs beyond the limit of 90 billion base pairs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s</para>
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket that stores the data of the WGS workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gene-shenzhen</para>
        /// </summary>
        [NameInMap("wgs_bucket_name")]
        [Validation(Required=false)]
        public string WgsBucketName { get; set; }

        /// <summary>
        /// <para>The name of the first FASTQ file of the WGS workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MGISEQ2000_PCR-free_NA12878_1_V100003043_L01_1.fq.gz</para>
        /// </summary>
        [NameInMap("wgs_fastq_first_filename")]
        [Validation(Required=false)]
        public string WgsFastqFirstFilename { get; set; }

        /// <summary>
        /// <para>The path of the FASTQ files of the WGS workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fastq/MGISEQ2000</para>
        /// </summary>
        [NameInMap("wgs_fastq_path")]
        [Validation(Required=false)]
        public string WgsFastqPath { get; set; }

        /// <summary>
        /// <para>The name of the second FASTQ file of the WGS workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MGISEQ2000_PCR-free_NA12878_1_V100003043_L01_2.fq.gz</para>
        /// </summary>
        [NameInMap("wgs_fastq_second_filename")]
        [Validation(Required=false)]
        public string WgsFastqSecondFilename { get; set; }

        /// <summary>
        /// <para>The region where the OSS bucket that stores the data of the whole genome sequencing (WGS) workflow is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("wgs_oss_region")]
        [Validation(Required=false)]
        public string WgsOssRegion { get; set; }

        /// <summary>
        /// <para>The path of the reference files of the WGS workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reference/hg19</para>
        /// </summary>
        [NameInMap("wgs_reference_path")]
        [Validation(Required=false)]
        public string WgsReferencePath { get; set; }

        /// <summary>
        /// <para>The name of the output VCF file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc.vcf</para>
        /// </summary>
        [NameInMap("wgs_vcf_out_filename")]
        [Validation(Required=false)]
        public string WgsVcfOutFilename { get; set; }

        /// <summary>
        /// <para>The output path of the Variant Call Format (VCF) file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>output/vcf</para>
        /// </summary>
        [NameInMap("wgs_vcf_out_path")]
        [Validation(Required=false)]
        public string WgsVcfOutPath { get; set; }

        /// <summary>
        /// <para>The type of workflow. Valid values: wgs and mapping.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mapping</para>
        /// </summary>
        [NameInMap("workflow_type")]
        [Validation(Required=false)]
        public string WorkflowType { get; set; }

    }

}
