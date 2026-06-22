// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterHostSecuritySummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
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
        /// <item><description><b>instanceId</b>: instance ID.</description></item>
        /// <item><description><b>appName</b>: application name.</description></item>
        /// <item><description><b>clusterId</b>: cluster ID.</description></item>
        /// <item><description><b>regionId</b>: region.</description></item>
        /// <item><description><b>nodeName</b>: node name.</description></item>
        /// <item><description><b>namespace</b>: namespace.</description></item>
        /// <item><description><b>clusterName</b>: cluster name.</description></item>
        /// <item><description><b>image</b>: image name.</description></item>
        /// <item><description><b>imageRepoName</b>: image repository name.</description></item>
        /// <item><description><b>imageRepoNamespace</b>: image repository namespace.</description></item>
        /// <item><description><b>imageRepoTag</b>: image tag.</description></item>
        /// <item><description><b>imageDigest</b>: image digest.</description></item>
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
        /// <para>c1fdb5fd8d42e425d88fd73eec7be****</para>
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
        /// <para>222.71.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: container ID.</description></item>
        /// <item><description><b>uuid</b>: asset ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
