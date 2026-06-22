// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterImageSecuritySummaryRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3aaf6c8085f84791882eef200cd2****</para>
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
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container search field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2ac28b2d0c734df29a21d29f18ac****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The image digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>402902de6480a020b9f29e7105e77b8a218bc1cccbc3935d3b38c8ea9ba2****</para>
        /// </summary>
        [NameInMap("ImageDigest")]
        [Validation(Required=false)]
        public string ImageDigest { get; set; }

        /// <summary>
        /// <para>The image repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo</para>
        /// </summary>
        [NameInMap("ImageRepoName")]
        [Validation(Required=false)]
        public string ImageRepoName { get; set; }

        /// <summary>
        /// <para>The image repository namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("ImageRepoNamespace")]
        [Validation(Required=false)]
        public string ImageRepoNamespace { get; set; }

        /// <summary>
        /// <para>The image tag.</para>
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
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.190.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
