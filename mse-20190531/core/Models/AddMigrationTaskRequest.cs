// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMigrationTaskRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("OriginInstanceAddress")]
        [Validation(Required=false)]
        public string OriginInstanceAddress { get; set; }

        [NameInMap("OriginInstanceName")]
        [Validation(Required=false)]
        public string OriginInstanceName { get; set; }

        [NameInMap("OriginInstanceNamespace")]
        [Validation(Required=false)]
        public string OriginInstanceNamespace { get; set; }

        [NameInMap("ProjectDesc")]
        [Validation(Required=false)]
        public string ProjectDesc { get; set; }

        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        [NameInMap("TargetClusterName")]
        [Validation(Required=false)]
        public string TargetClusterName { get; set; }

        [NameInMap("TargetClusterUrl")]
        [Validation(Required=false)]
        public string TargetClusterUrl { get; set; }

        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

    }

}
