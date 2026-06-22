// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAssetsSecurityEventSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster that you want to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cc58f827d893f4d7fb3e34b5d4395****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The container search field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: container instance ID</description></item>
        /// <item><description><b>clusterId</b>: cluster ID</description></item>
        /// <item><description><b>regionId</b>: container region</description></item>
        /// <item><description><b>clusterName</b>: cluster name</description></item>
        /// <item><description><b>image</b>: image name</description></item>
        /// <item><description><b>imageRepoName</b>: image repository name</description></item>
        /// <item><description><b>imageRepoNamespace</b>: image repository namespace</description></item>
        /// <item><description><b>imageRepoTag</b>: image repository tag</description></item>
        /// <item><description><b>imageDigest</b>: image digest</description></item>
        /// <item><description><b>clusterType</b>: cluster type</description></item>
        /// <item><description><b>hostIp</b>: public IP address</description></item>
        /// <item><description><b>pod</b>: pod</description></item>
        /// <item><description><b>podIp</b>: pod IP address</description></item>
        /// <item><description><b>containerId</b>: container ID</description></item>
        /// <item><description><b>vulStatus</b>: whether the container has vulnerabilities</description></item>
        /// <item><description><b>alarmStatus</b>: whether the container has security alerts</description></item>
        /// <item><description><b>riskStatus</b>: whether the container has risks</description></item>
        /// <item><description><b>riskLevel</b>: container risk level</description></item>
        /// <item><description><b>containerScope</b>: container type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clusterName</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container search field.</para>
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
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.108.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
