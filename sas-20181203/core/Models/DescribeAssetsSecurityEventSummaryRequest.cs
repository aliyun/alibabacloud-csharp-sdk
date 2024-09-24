// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsSecurityEventSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster to which the container belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the IDs of clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cc58f827d893f4d7fb3e34b5d4395****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The key of the condition that is used to query on containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: the ID of the container instance</description></item>
        /// <item><description><b>clusterId</b>: the ID of the cluster</description></item>
        /// <item><description><b>regionId</b>: the region ID of the container</description></item>
        /// <item><description><b>clusterName</b>: the name of the cluster</description></item>
        /// <item><description><b>image</b>: the name of the image</description></item>
        /// <item><description><b>imageRepoName</b>: the name of the image repository</description></item>
        /// <item><description><b>imageRepoNamespace</b>: the namespace to which the image repository belongs</description></item>
        /// <item><description><b>imageRepoTag</b>: the tag that is added to the image repository</description></item>
        /// <item><description><b>imageDigest</b>: the digest of the image</description></item>
        /// <item><description><b>ClusterType</b>: the type of the cluster</description></item>
        /// <item><description><b>hostIp</b>: the public IP address</description></item>
        /// <item><description><b>pod</b>: the pod</description></item>
        /// <item><description><b>podIp</b>: the IP address of the pod</description></item>
        /// <item><description><b>containerId</b>: the ID of the container</description></item>
        /// <item><description><b>vulStatus</b>: whether vulnerabilities are detected on the container</description></item>
        /// <item><description><b>alarmStatus</b>: whether alerts are generated for the container</description></item>
        /// <item><description><b>riskStatus</b>: whether risks are detected on the container</description></item>
        /// <item><description><b>riskLevel</b>: the risk level of the container</description></item>
        /// <item><description><b>containerScope</b>: the type of the container</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clusterName</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the condition that is used to query on containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms-prom-operator</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.108.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
