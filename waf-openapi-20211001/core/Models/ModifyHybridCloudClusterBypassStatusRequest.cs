// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudClusterBypassStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdbc_cluster_****</para>
        /// </summary>
        [NameInMap("ClusterResourceId")]
        [Validation(Required=false)]
        public string ClusterResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <para>**</para>
        /// <para>**You can call the **DescribeInstanceInfo<a href="https://help.aliyun.com/document_detail/140857.html"> operation to obtain the ID of the WAF instance.</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0xldbqt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of manual bypass. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled. This is the default value.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

    }

}
