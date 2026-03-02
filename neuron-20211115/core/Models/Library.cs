// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class Library : TeaModel {
        [NameInMap("artifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        [NameInMap("assetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        [NameInMap("company")]
        [Validation(Required=false)]
        public string Company { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("dependCount")]
        [Validation(Required=false)]
        public int? DependCount { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("isWatched")]
        [Validation(Required=false)]
        public bool? IsWatched { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("providerName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        [NameInMap("repoUrl")]
        [Validation(Required=false)]
        public string RepoUrl { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("reviewId")]
        [Validation(Required=false)]
        public long? ReviewId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("stepStatus")]
        [Validation(Required=false)]
        public string StepStatus { get; set; }

        [NameInMap("watchCount")]
        [Validation(Required=false)]
        public int? WatchCount { get; set; }

    }

}
