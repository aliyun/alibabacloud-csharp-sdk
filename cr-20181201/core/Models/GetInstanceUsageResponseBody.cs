// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceUsageResponseBody : TeaModel {
        [NameInMap("NamespaceUsage")]
        [Validation(Required=false)]
        public string NamespaceUsage { get; set; }

        [NameInMap("RepoQuota")]
        [Validation(Required=false)]
        public string RepoQuota { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ChartNamespaceQuota")]
        [Validation(Required=false)]
        public string ChartNamespaceQuota { get; set; }

        [NameInMap("RepoUsage")]
        [Validation(Required=false)]
        public string RepoUsage { get; set; }

        [NameInMap("NamespaceQuota")]
        [Validation(Required=false)]
        public string NamespaceQuota { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("ChartRepoUsage")]
        [Validation(Required=false)]
        public string ChartRepoUsage { get; set; }

        [NameInMap("ChartNamespaceUsage")]
        [Validation(Required=false)]
        public string ChartNamespaceUsage { get; set; }

        [NameInMap("ChartRepoQuota")]
        [Validation(Required=false)]
        public string ChartRepoQuota { get; set; }

    }

}
