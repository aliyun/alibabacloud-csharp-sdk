// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventLevelCountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the IDs of container clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c7e3c5b420a7947c2933303144688****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The key of the condition that is used to query alert events on containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: the ID of the asset</description></item>
        /// <item><description><b>appName</b>: the name of the application</description></item>
        /// <item><description><b>clusterId</b>: the ID of the cluster</description></item>
        /// <item><description><b>regionId</b>: the ID of the region</description></item>
        /// <item><description><b>nodeName</b>: the name of the node</description></item>
        /// <item><description><b>namespace</b>: the namespace</description></item>
        /// <item><description><b>clusterName</b>: the name of the cluster</description></item>
        /// <item><description><b>image</b>: the name of the image</description></item>
        /// <item><description><b>imageRepoName</b>: the name of the image repository</description></item>
        /// <item><description><b>imageRepoNamespace</b>: the namespace to which the image repository belongs</description></item>
        /// <item><description><b>imageRepoTag</b>: the tag that is added to the image</description></item>
        /// <item><description><b>imageDigest</b>: the digest of the image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the condition that is used to query alert events on containers. If you specify multiple values, separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>c951761046a9c4afe92be0a7b5bexxxxx</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The ID of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx30389a10c28f6d38f2398f0dcexxxxxxx922b9e8290dc7c3019d4a8,48b87f2c0662e334820f436cb9133f1ae4e053d39b6fad42xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ContainerIds")]
        [Validation(Required=false)]
        public string ContainerIds { get; set; }

        /// <summary>
        /// <para>The ID of the request source. Set the value to <b>sas</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The type of the accounts that you want to query. Default value: <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the current account.</description></item>
        /// <item><description><b>1</b>: all accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MultiAccountActionType")]
        [Validation(Required=false)]
        public int? MultiAccountActionType { get; set; }

        /// <summary>
        /// <para>The type of the query condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>containerId</b>: the ID of the container</description></item>
        /// <item><description><b>uuid</b>: the UUID of the asset</description></item>
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
