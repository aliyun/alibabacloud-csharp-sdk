// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListK8sAccessInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of K8s access information.</para>
        /// </summary>
        [NameInMap("K8sAccessInfos")]
        [Validation(Required=false)]
        public List<ListK8sAccessInfoResponseBodyK8sAccessInfos> K8sAccessInfos { get; set; }
        public class ListK8sAccessInfoResponseBodyK8sAccessInfos : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud UID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1960721413485****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The Simple Log Service Logstore for audit logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit-cf6baf6afa106eca665296fdf68b****</para>
            /// </summary>
            [NameInMap("AuditLogStore")]
            [Validation(Required=false)]
            public string AuditLogStore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project for audit logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-custom-your-project-sd89eh****</para>
            /// </summary>
            [NameInMap("AuditProject")]
            [Validation(Required=false)]
            public string AuditProject { get; set; }

            /// <summary>
            /// <para>The region ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("AuditRegionId")]
            [Validation(Required=false)]
            public string AuditRegionId { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0da5e4cb82a848c4a57c4dc9f49a****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The CPU architecture. Valid values: ARM architecture and x86 architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arm</para>
            /// </summary>
            [NameInMap("CpuArch")]
            [Validation(Required=false)]
            public string CpuArch { get; set; }

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
            /// <para>The server group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11088522</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The server group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The unique ID of the access information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67070</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The K8s installation key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("InstallKey")]
            [Validation(Required=false)]
            public string InstallKey { get; set; }

            /// <summary>
            /// <para>The vendor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The China Chinese Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
