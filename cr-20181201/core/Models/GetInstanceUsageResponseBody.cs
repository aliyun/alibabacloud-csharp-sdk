// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceUsageResponseBody : TeaModel {
        /// <summary>
        /// The quota of chart namespaces.
        /// </summary>
        [NameInMap("ChartNamespaceQuota")]
        [Validation(Required=false)]
        public string ChartNamespaceQuota { get; set; }

        /// <summary>
        /// The number of chart namespaces that are created in the instance.
        /// </summary>
        [NameInMap("ChartNamespaceUsage")]
        [Validation(Required=false)]
        public string ChartNamespaceUsage { get; set; }

        /// <summary>
        /// The quota of chart repositories for the instance.
        /// </summary>
        [NameInMap("ChartRepoQuota")]
        [Validation(Required=false)]
        public string ChartRepoQuota { get; set; }

        /// <summary>
        /// The number of chart repositories that are created.
        /// </summary>
        [NameInMap("ChartRepoUsage")]
        [Validation(Required=false)]
        public string ChartRepoUsage { get; set; }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request fails.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The quota of image namespaces for the instance.
        /// </summary>
        [NameInMap("NamespaceQuota")]
        [Validation(Required=false)]
        public string NamespaceQuota { get; set; }

        /// <summary>
        /// The number of image namespaces that are created in the instance.
        /// </summary>
        [NameInMap("NamespaceUsage")]
        [Validation(Required=false)]
        public string NamespaceUsage { get; set; }

        /// <summary>
        /// The quota of image repositories for the instance.
        /// </summary>
        [NameInMap("RepoQuota")]
        [Validation(Required=false)]
        public string RepoQuota { get; set; }

        /// <summary>
        /// The number of image repositories that are created in the instance.
        /// </summary>
        [NameInMap("RepoUsage")]
        [Validation(Required=false)]
        public string RepoUsage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
