// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterImageSecuritySummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3aaf6c8085f84791882eef200cd2****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The key of the condition that is used to query containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: the instance ID of the container</description></item>
        /// <item><description><b>clusterId</b>: the ID of the cluster</description></item>
        /// <item><description><b>regionId</b>: the region ID of the container</description></item>
        /// <item><description><b>clusterName</b>: the name of the cluster</description></item>
        /// <item><description><b>image</b>: the name of the image</description></item>
        /// <item><description><b>imageRepoName</b>: the name of the image repository</description></item>
        /// <item><description><b>imageRepoNamespace</b>: the namespace to which the image repository belongs</description></item>
        /// <item><description><b>imageRepoTag</b>: the tag that is added to the image repository</description></item>
        /// <item><description><b>imageDigest</b>: the digest of the image</description></item>
        /// <item><description><b>clusterType</b>: the type of the cluster</description></item>
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
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the condition that is used to query containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2ac28b2d0c734df29a21d29f18ac****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The digest of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>402902de6480a020b9f29e7105e77b8a218bc1cccbc3935d3b38c8ea9ba2****</para>
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <para>The name of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo</para>
        /// </summary>
        [NameInMap("ImageRepoName")]
        [Validation(Required=false)]
        public string ImageRepoName { get; set; }

        /// <summary>
        /// <para>The namespace of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("ImageRepoNamespace")]
        [Validation(Required=false)]
        public string ImageRepoNamespace { get; set; }

        /// <summary>
        /// <para>The tag of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.54.0.1</para>
        /// </summary>
        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.190.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
