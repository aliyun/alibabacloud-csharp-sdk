// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListUserKubeConfigStatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public ListUserKubeConfigStatesResponseBodyPage Page { get; set; }
        public class ListUserKubeConfigStatesResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The status of the kubeconfig files.</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListUserKubeConfigStatesResponseBodyStates> States { get; set; }
        public class ListUserKubeConfigStatesResponseBodyStates : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate used in a kubeconfig file. Format: the UTC time in the RFC3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-30T07:41:50Z</para>
            /// </summary>
            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            /// <summary>
            /// <para>The current status of the certificate used in a kubeconfig file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Expired: The certificate is expired.</description></item>
            /// <item><description>Unexpired: The certificate is not expired.</description></item>
            /// <item><description>Unissued: The certificate is not issued.</description></item>
            /// <item><description>Unknown: The status of the certificate is unknown.</description></item>
            /// <item><description>Removed: The certificate is removed. An issue record is found for the certificate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unissued</para>
            /// </summary>
            [NameInMap("cert_state")]
            [Validation(Required=false)]
            public string CertState { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5b5e80b0b64a4bf6939d2d8fbbc5****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// <para>The name must be 1 to 63 characters in length, and can contain digits, underscores (_), and hyphens (-). The name must start with a letter or number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-demo</para>
            /// </summary>
            [NameInMap("cluster_name")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>initial</c>: The cluster is being created.</description></item>
            /// <item><description><c>failed</c>: The cluster failed to be created.</description></item>
            /// <item><description><c>running</c>: The cluster is running.</description></item>
            /// <item><description><c>updating</c>: The cluster is being upgraded.</description></item>
            /// <item><description><c>updating_failed</c>: The cluster failed to be updated.</description></item>
            /// <item><description><c>scaling</c>: The cluster is being scaled.</description></item>
            /// <item><description><c>stopped</c>: The cluster is stopped.</description></item>
            /// <item><description><c>deleting</c>: The cluster is being deleted.</description></item>
            /// <item><description><c>deleted</c>: The cluster is deleted.</description></item>
            /// <item><description><c>delete_failed</c>: The cluster failed to be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("cluster_state")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

        }

    }

}
