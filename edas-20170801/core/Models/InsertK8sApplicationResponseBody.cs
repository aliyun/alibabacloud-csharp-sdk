// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertK8sApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application.</para>
        /// </summary>
        [NameInMap("ApplicationInfo")]
        [Validation(Required=false)]
        public InsertK8sApplicationResponseBodyApplicationInfo ApplicationInfo { get; set; }
        public class InsertK8sApplicationResponseBodyApplicationInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e83acea6-<b><b>-47e1-96ae-c0e95377</b></b></para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the change process. You can call the GetChangeOrderInfo operation to query the ID. For more information, see <a href="https://help.aliyun.com/document_detail/62072.html">GetChangeOrderInfo</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd65b247-****-475b-ad4b-7039040d625c</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>The type of the cluster in which the application is deployed.</para>
            /// <list type="bullet">
            /// <item><description><para>0: regular Docker cluster.</para>
            /// </description></item>
            /// <item><description><para>1: Swarm cluster (discontinued).</para>
            /// </description></item>
            /// <item><description><para>2: ECS cluster.</para>
            /// </description></item>
            /// <item><description><para>3: self-managed Kubernetes cluster in EDAS (discontinued).</para>
            /// </description></item>
            /// <item><description><para>4: cluster for applications that are automatically registered with Pandora.</para>
            /// </description></item>
            /// <item><description><para>5: Kubernetes clusters and Serverless Kubernetes clusters.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is a Docker application.</para>
            /// <list type="bullet">
            /// <item><description><para>true: The application is a Docker application.</para>
            /// </description></item>
            /// <item><description><para>false: The application is not a Docker application.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Dockerize")]
            [Validation(Required=false)]
            public bool? Dockerize { get; set; }

            /// <summary>
            /// <para>The ID of the user account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1172<b><b>6608</b></b></para>
            /// </summary>
            [NameInMap("EdasId")]
            [Validation(Required=false)]
            public string EdasId { get; set; }

            /// <summary>
            /// <para>The owner of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zp</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that is used to create the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas_test****@aliyun****.com</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The status code of the interface or the POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
