// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListK8sAccessInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the Kubernetes clusters.</para>
        /// </summary>
        [NameInMap("K8sAccessInfos")]
        [Validation(Required=false)]
        public List<ListK8sAccessInfoResponseBodyK8sAccessInfos> K8sAccessInfos { get; set; }
        public class ListK8sAccessInfoResponseBodyK8sAccessInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1960721413485****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The Simple Log Service Logstore that is used to store the audit logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit-cf6baf6afa106eca665296fdf68b****</para>
            /// </summary>
            [NameInMap("AuditLogStore")]
            [Validation(Required=false)]
            public string AuditLogStore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project that is used to store the audit logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-custom-your-project-sd89eh****</para>
            /// </summary>
            [NameInMap("AuditProject")]
            [Validation(Required=false)]
            public string AuditProject { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the server is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("AuditRegionId")]
            [Validation(Required=false)]
            public string AuditRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0da5e4cb82a848c4a57c4dc9f49a****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1690596321613</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            /// <summary>
            /// <para>The ID of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11088522</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The UUID of the access information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67070</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The installation key of the Kubernetes cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("InstallKey")]
            [Validation(Required=false)]
            public string InstallKey { get; set; }

            /// <summary>
            /// <para>The service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
