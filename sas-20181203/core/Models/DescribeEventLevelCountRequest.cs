// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventLevelCountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster that you want to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c7e3c5b420a7947c2933303144688****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The container search field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: instance ID</description></item>
        /// <item><description><b>appName</b>: application name</description></item>
        /// <item><description><b>clusterId</b>: cluster ID</description></item>
        /// <item><description><b>regionId</b>: region</description></item>
        /// <item><description><b>nodeName</b>: node name</description></item>
        /// <item><description><b>namespace</b>: namespace</description></item>
        /// <item><description><b>clusterName</b>: cluster name</description></item>
        /// <item><description><b>image</b>: image name</description></item>
        /// <item><description><b>imageRepoName</b>: image repository name</description></item>
        /// <item><description><b>imageRepoNamespace</b>: image repository namespace</description></item>
        /// <item><description><b>imageRepoTag</b>: image tag</description></item>
        /// <item><description><b>imageDigest</b>: image digest</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the field that you want to query. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>c951761046a9c4afe92be0a7b5bexxxxx</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The container IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx30389a10c28f6d38f2398f0dcexxxxxxx922b9e8290dc7c3019d4a8,48b87f2c0662e334820f436cb9133f1ae4e053d39b6fad42xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ContainerIds")]
        [Validation(Required=false)]
        public string ContainerIds { get; set; }

        /// <summary>
        /// <para>The source identifier of the request. Set this parameter to <b>sas</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The multi-account query type. Default value: <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Query data of the current account.</description></item>
        /// <item><description><b>1</b>: Query data of all accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MultiAccountActionType")]
        [Validation(Required=false)]
        public int? MultiAccountActionType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: container ID</description></item>
        /// <item><description><b>uuid</b>: asset ID</description></item>
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
