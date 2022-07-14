// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitEditingJobsRequest : TeaModel {
        [NameInMap("EditingInputs")]
        [Validation(Required=false)]
        public string EditingInputs { get; set; }

        [NameInMap("EditingJobOssFileRoleArn")]
        [Validation(Required=false)]
        public string EditingJobOssFileRoleArn { get; set; }

        [NameInMap("EditingJobOssFileUid")]
        [Validation(Required=false)]
        public long? EditingJobOssFileUid { get; set; }

        [NameInMap("EditingJobOutputs")]
        [Validation(Required=false)]
        public string EditingJobOutputs { get; set; }

        [NameInMap("EditingJobURL")]
        [Validation(Required=false)]
        public string EditingJobURL { get; set; }

        [NameInMap("OutputBucket")]
        [Validation(Required=false)]
        public string OutputBucket { get; set; }

        [NameInMap("OutputLocation")]
        [Validation(Required=false)]
        public string OutputLocation { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
