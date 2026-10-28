// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class CreateVirtualClusterRequest : TeaModel {
        /// <summary>
        /// <para>The primary cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****
        /// -be</para>
        /// </summary>
        [NameInMap("ActiveClusterId")]
        [Validation(Required=false)]
        public string ActiveClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name. The name must start with a letter and can be up to 64 characters in length. It can contain letters (case-insensitive), digits, and underscores (<em>). It cannot contain two or more consecutive underscores (</em>). Cluster names must be unique within the same instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcg_demo</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The standby cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-26a3cjv****
        /// -be</para>
        /// </summary>
        [NameInMap("StandbyClusterId")]
        [Validation(Required=false)]
        public string StandbyClusterId { get; set; }

    }

}
