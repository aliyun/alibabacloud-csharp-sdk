// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeAppInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The application instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeAppInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeAppInstanceListResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93fdd228-*****-ed2ae98de18d</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Indicates whether the application was released in canary release mode.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The application was released in canary release mode.</description></item>
            /// <item><description><c>false</c>: The application was not released in canary release mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Canary")]
            [Validation(Required=false)]
            public bool? Canary { get; set; }

            /// <summary>
            /// <para>The ID of the instance group to which the application is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93fdd228-*****-ed2ae98de18d</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the instance group to which the application is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The labels of the node. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;alibabacloud.com/nodepool-id&quot;:&quot;np0<em>5b9377fa907&quot;,&quot;beta.kubernetes.io/arch&quot;:&quot;amd64&quot;,&quot;beta.kubernetes.io/instance-type&quot;:&quot;ecs.</em>&quot;,&quot;beta.kubernetes.io/os&quot;:&quot;linux&quot;,&quot;failure-domain.beta.kubernetes.io/region&quot;:&quot;cn-hangzhou&quot;,&quot;failure-domain.beta.kubernetes.io/zone&quot;:&quot;cn-hangzhou-b&quot;,&quot;kubernetes.io/arch&quot;:&quot;amd64&quot;,&quot;kubernetes.io/hostname&quot;:&quot;cn-hangzhou*&quot;,&quot;kubernetes.io/os&quot;:&quot;linux&quot;,&quot;node.kubernetes.io/instance-type&quot;:&quot;ecs.*&quot;,&quot;topology.diskplugin.csi.alibabacloud.com/zone&quot;:&quot;cn-hangzhou-b&quot;,&quot;topology.kubernetes.io/region&quot;:&quot;cn-hangzhou&quot;,&quot;topology.kubernetes.io/zone&quot;:&quot;cn-hangzhou-b&quot;}</para>
            /// </summary>
            [NameInMap("NodeLabels")]
            [Validation(Required=false)]
            public string NodeLabels { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou.192.168.0.*</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The information about the pod. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;metadata&quot;:{&quot;name&quot;:&quot;oambuild-group-1-<em>4xthz&quot;,&quot;generateName&quot;:&quot;oambuild-group-<em>96-&quot;,&quot;namespace&quot;:&quot;default&quot;,&quot;selfLink&quot;:&quot;/api/v1/namespaces/default/pods/oambuild-grou</em>96-4xthz&quot;,&quot;uid&quot;:&quot;7a23399c-<em>fe7ff4018&quot;,&quot;resourceVersion&quot;:&quot;969614830&quot;,&quot;creationTimestamp&quot;:&quot;2021-04-06T11:38:46Z&quot;,&quot;labels&quot;:{&quot;ARMSApmAppId&quot;:&quot;</em>&quot;,&quot;ARMSApmLicenseKey&quot;:&quot;</em>&quot;...</para>
            /// </summary>
            [NameInMap("PodRaw")]
            [Validation(Required=false)]
            public string PodRaw { get; set; }

            /// <summary>
            /// <para>The deployment package version of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-06 19:37:42</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
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
        /// <para>03FD1520-0FD6-436A-<b><b>-265318D7</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
