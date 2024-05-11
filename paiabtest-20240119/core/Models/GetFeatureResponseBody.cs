// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIABTest20240119.Models
{
    public class GetFeatureResponseBody : TeaModel {
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        [NameInMap("ExperimentName")]
        [Validation(Required=false)]
        public string ExperimentName { get; set; }

        [NameInMap("ExperimentOwner")]
        [Validation(Required=false)]
        public string ExperimentOwner { get; set; }

        [NameInMap("ExperimentVersionId")]
        [Validation(Required=false)]
        public string ExperimentVersionId { get; set; }

        [NameInMap("ExperimentVersionName")]
        [Validation(Required=false)]
        public string ExperimentVersionName { get; set; }

        [NameInMap("FeatureId")]
        [Validation(Required=false)]
        public string FeatureId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public string ReleaseTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
