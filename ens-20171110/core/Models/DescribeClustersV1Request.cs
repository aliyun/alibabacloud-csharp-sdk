// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClustersV1Request : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values: Kubernetes and ManagedKubernetes. A value of Kubernetes indicates an ECK cluster. A value of ManagedKubernetes indicates a serverless virtual cluster. This parameter must be used together with the profile parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The ENS region ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-58</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-eck-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The cluster profile. Valid values: Default and Serverless. A value of Default indicates an ECK cluster. A value of Serverless indicates a serverless virtual cluster. This parameter must be used together with the cluster_type parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

    }

}
