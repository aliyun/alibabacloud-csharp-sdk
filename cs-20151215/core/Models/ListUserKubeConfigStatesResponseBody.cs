// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListUserKubeConfigStatesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public ListUserKubeConfigStatesResponseBodyPage Page { get; set; }
        public class ListUserKubeConfigStatesResponseBodyPage : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The status of the kubeconfig files.
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListUserKubeConfigStatesResponseBodyStates> States { get; set; }
        public class ListUserKubeConfigStatesResponseBodyStates : TeaModel {
            /// <summary>
            /// The expiration date of the certificate used in a kubeconfig file. Format: the UTC time in the RFC3339 format.
            /// </summary>
            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            /// <summary>
            /// The current status of the certificate used in a kubeconfig file. Valid values:
            /// 
            /// *   Expired: The certificate is expired.
            /// *   Unexpired: The certificate is not expired.
            /// *   Unissued: The certificate is not issued.
            /// *   Unknown: The status of the certificate is unknown.
            /// *   Removed: The certificate is removed. An issue record is found for the certificate.
            /// </summary>
            [NameInMap("cert_state")]
            [Validation(Required=false)]
            public string CertState { get; set; }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The cluster name.
            /// 
            /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).
            /// </summary>
            [NameInMap("cluster_name")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values:
            /// 
            /// *   `initial`: The cluster is being created.
            /// *   `failed`: The cluster failed to be created.
            /// *   `running`: The cluster is running.
            /// *   `updating`: The cluster is being upgraded.
            /// *   `updating_failed`: The cluster failed to be updated.
            /// *   `scaling`: The cluster is being scaled.
            /// *   `waiting`: The cluster is waiting for connection requests.
            /// *   `disconnected`: The cluster is disconnected.
            /// *   `stopped`: The cluster is stopped.
            /// *   `deleting`: The cluster is being deleted.
            /// *   `deleted`: The cluster is deleted.
            /// *   `delete_failed`: The cluster failed to be deleted.
            /// </summary>
            [NameInMap("cluster_state")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

        }

    }

}
