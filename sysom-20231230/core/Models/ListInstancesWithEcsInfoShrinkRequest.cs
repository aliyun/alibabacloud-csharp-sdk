// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstancesWithEcsInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>healthy</para>
        /// </summary>
        [NameInMap("health_status")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-bp118piqcio9tiwgh84b</para>
        /// </summary>
        [NameInMap("instance_id")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>84b</para>
        /// </summary>
        [NameInMap("instance_id_name")]
        [Validation(Required=false)]
        public string InstanceIdName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>block-load-balancer-hjdm9</para>
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("instance_tag")]
        [Validation(Required=false)]
        public string InstanceTagShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("is_managed")]
        [Validation(Required=false)]
        public int? IsManaged { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Linux  3.2104 LTS 64bit</para>
        /// </summary>
        [NameInMap("os_name")]
        [Validation(Required=false)]
        public string OsName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("private_ip")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("public_ip")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-xxxxxxx</para>
        /// </summary>
        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("resource_group_id_name")]
        [Validation(Required=false)]
        public string ResourceGroupIdName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default resource group</para>
        /// </summary>
        [NameInMap("resource_group_name")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
