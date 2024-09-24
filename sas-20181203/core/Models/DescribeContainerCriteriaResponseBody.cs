// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of information about the filter condition.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeContainerCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeContainerCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: the ID of the container instance.</description></item>
            /// <item><description><b>clusterId</b>: the cluster ID.</description></item>
            /// <item><description><b>regionId</b>: the ID of the region in which the container resides.</description></item>
            /// <item><description><b>clusterName</b>: the name of the cluster.</description></item>
            /// <item><description><b>image</b>: the name of the image.</description></item>
            /// <item><description><b>imageRepoName</b>: the name of the image repository.</description></item>
            /// <item><description><b>imageRepoNamespace</b>: the namespace of the image repository.</description></item>
            /// <item><description><b>imageRepoTag</b>: the tag of the image repository.</description></item>
            /// <item><description><b>imageDigest</b>: the image digest.</description></item>
            /// <item><description><b>ClusterType</b>: the type of the cluster.</description></item>
            /// <item><description><b>hostIp</b>: the public IP address.</description></item>
            /// <item><description><b>pod</b>: the pod.</description></item>
            /// <item><description><b>podIp</b>: the IP address of the pod.</description></item>
            /// <item><description><b>containerId</b>: the container ID.</description></item>
            /// <item><description><b>vulStatus</b>: indicates whether vulnerabilities exist in the container.</description></item>
            /// <item><description><b>alarmStatus</b>: indicates whether alerts are generated for the container.</description></item>
            /// <item><description><b>riskStatus</b>: indicates whether risks exist in the container.</description></item>
            /// <item><description><b>riskLevel</b>: the risk level of the container.</description></item>
            /// <item><description><b>containerScope</b>: the type of the container.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>clusterId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: The search condition needs to be specified.</description></item>
            /// <item><description><b>select</b>: The search condition is an option that can be selected from the drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The values of the search condition. This parameter is returned only if the value of <b>Type</b> is set to <b>select</b>.</para>
            /// <remarks>
            /// <para>If the value of <b>Type</b> is set to <b>input</b>, the return value of this parameter is empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes,NotManagedKubernetes,PrivateKubernetes</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
