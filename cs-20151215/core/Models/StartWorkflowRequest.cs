// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class StartWorkflowRequest : TeaModel {
        [NameInMap("mapping_bam_out_filename")]
        [Validation(Required=false)]
        public string MappingBamOutFilename { get; set; }

        [NameInMap("mapping_bam_out_path")]
        [Validation(Required=false)]
        public string MappingBamOutPath { get; set; }

        [NameInMap("mapping_bucket_name")]
        [Validation(Required=false)]
        public string MappingBucketName { get; set; }

        [NameInMap("mapping_fastq_first_filename")]
        [Validation(Required=false)]
        public string MappingFastqFirstFilename { get; set; }

        [NameInMap("mapping_fastq_path")]
        [Validation(Required=false)]
        public string MappingFastqPath { get; set; }

        [NameInMap("mapping_fastq_second_filename")]
        [Validation(Required=false)]
        public string MappingFastqSecondFilename { get; set; }

        [NameInMap("mapping_is_mark_dup")]
        [Validation(Required=false)]
        public string MappingIsMarkDup { get; set; }

        [NameInMap("mapping_oss_region")]
        [Validation(Required=false)]
        public string MappingOssRegion { get; set; }

        [NameInMap("mapping_reference_path")]
        [Validation(Required=false)]
        public string MappingReferencePath { get; set; }

        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        [NameInMap("wgs_bucket_name")]
        [Validation(Required=false)]
        public string WgsBucketName { get; set; }

        [NameInMap("wgs_fastq_first_filename")]
        [Validation(Required=false)]
        public string WgsFastqFirstFilename { get; set; }

        [NameInMap("wgs_fastq_path")]
        [Validation(Required=false)]
        public string WgsFastqPath { get; set; }

        [NameInMap("wgs_fastq_second_filename")]
        [Validation(Required=false)]
        public string WgsFastqSecondFilename { get; set; }

        [NameInMap("wgs_oss_region")]
        [Validation(Required=false)]
        public string WgsOssRegion { get; set; }

        [NameInMap("wgs_reference_path")]
        [Validation(Required=false)]
        public string WgsReferencePath { get; set; }

        [NameInMap("wgs_vcf_out_filename")]
        [Validation(Required=false)]
        public string WgsVcfOutFilename { get; set; }

        [NameInMap("wgs_vcf_out_path")]
        [Validation(Required=false)]
        public string WgsVcfOutPath { get; set; }

        [NameInMap("workflow_type")]
        [Validation(Required=false)]
        public string WorkflowType { get; set; }

    }

}
