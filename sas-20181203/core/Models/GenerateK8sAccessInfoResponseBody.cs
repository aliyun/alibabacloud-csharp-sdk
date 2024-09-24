// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateK8sAccessInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateK8sAccessInfoResponseBodyData Data { get; set; }
        public class GenerateK8sAccessInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104***</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The Simple Log Service Logstore that is used to store the audit logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit-cf6baf6afa106eca665296fdf68b65bf</para>
            /// </summary>
            [NameInMap("AuditLogStore")]
            [Validation(Required=false)]
            public string AuditLogStore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project that is used to store the audit logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-custom-your-project-sd89ehaaa</para>
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
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8ca91e0907d94efaba7fb0827eb9****</para>
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
            /// <para>The expiration time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1804230578566</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            /// <summary>
            /// <para>The server group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11618788</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The installation key of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BC66185***</para>
            /// </summary>
            [NameInMap("InstallKey")]
            [Validation(Required=false)]
            public string InstallKey { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>061955B2-BC40-589F-AF63-C40A901EE279</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
