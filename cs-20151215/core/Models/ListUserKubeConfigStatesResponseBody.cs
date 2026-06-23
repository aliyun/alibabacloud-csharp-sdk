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
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The KubeConfig status details of the user.</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListUserKubeConfigStatesResponseBodyStates> States { get; set; }
        public class ListUserKubeConfigStatesResponseBodyStates : TeaModel {
            /// <summary>
            /// <para>The expiration time of the KubeConfig certificate. Format: UTC time in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2028-04-09T06:20:47Z</para>
            /// </summary>
            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            /// <summary>
            /// <para>The current status of the KubeConfig certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Expired: The certificate has expired.</para>
            /// </description></item>
            /// <item><description><para>Unexpired: The certificate has not expired.</para>
            /// </description></item>
            /// <item><description><para>Unissued: The certificate has not been issued.</para>
            /// </description></item>
            /// <item><description><para>Unknown: The status is unknown.</para>
            /// </description></item>
            /// <item><description><para>Removed: The certificate has been revoked. An issuance record exists for the certificate.</para>
            /// </description></item>
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
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-demo</para>
            /// </summary>
            [NameInMap("cluster_name")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The cluster status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>initial</c>: The cluster is being created.</description></item>
            /// <item><description><c>failed</c>: The cluster failed to be created.</description></item>
            /// <item><description><c>running</c>: The cluster is running.</description></item>
            /// <item><description><c>updating</c>: The cluster is being upgraded.</description></item>
            /// <item><description><c>updating_failed</c>: The cluster failed to be upgraded.</description></item>
            /// <item><description><c>scaling</c>: The cluster is being scaled.</description></item>
            /// <item><description><c>stopped</c>: The cluster has stopped running.</description></item>
            /// <item><description><c>deleting</c>: The cluster is being deleted.</description></item>
            /// <item><description><c>deleted</c>: The cluster has been deleted.</description></item>
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
