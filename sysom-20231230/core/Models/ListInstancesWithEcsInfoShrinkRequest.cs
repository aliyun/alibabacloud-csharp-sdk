// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstancesWithEcsInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This field exists when using paging and indicates the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>Filter instances by health status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>healthy</para>
        /// </summary>
        [NameInMap("health_status")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>If this field is specified, filter the Agent installation status for the specified instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp118piqcio9tiwgh84b</para>
        /// </summary>
        [NameInMap("instance_id")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Filter by instance name or instance ID. Fuzzy query is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84b</para>
        /// </summary>
        [NameInMap("instance_id_name")]
        [Validation(Required=false)]
        public string InstanceIdName { get; set; }

        /// <summary>
        /// <para>Widget instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block-load-balancer-hjdm9</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Filter by tags of instances.</para>
        /// </summary>
        [NameInMap("instance_tag")]
        [Validation(Required=false)]
        public string InstanceTagShrink { get; set; }

        /// <summary>
        /// <para>Filter instances by managed status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("is_managed")]
        [Validation(Required=false)]
        public int? IsManaged { get; set; }

        /// <summary>
        /// <para>Filter instances by operating system name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Linux  3.2104 LTS 64bit</para>
        /// </summary>
        [NameInMap("os_name")]
        [Validation(Required=false)]
        public string OsName { get; set; }

        /// <summary>
        /// <para>Page size. Default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filter instances by private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("private_ip")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// <para>Filter instances by public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("public_ip")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>Filter instances by region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Filter instances by resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxxxxxx</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Filter by resource group name or resource group ID. Fuzzy query is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("resource_group_id_name")]
        [Validation(Required=false)]
        public string ResourceGroupIdName { get; set; }

        /// <summary>
        /// <para>Filter instances by resource group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default resource group</para>
        /// </summary>
        [NameInMap("resource_group_name")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
