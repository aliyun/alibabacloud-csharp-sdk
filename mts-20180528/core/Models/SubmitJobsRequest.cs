// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class SubmitJobsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OutputBucket")]
        [Validation(Required=false)]
        public string OutputBucket { get; set; }

        [NameInMap("OutputLocation")]
        [Validation(Required=false)]
        public string OutputLocation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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
