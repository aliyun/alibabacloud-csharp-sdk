// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ExecuteTerraformApplyRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. Use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The Terraform code to execute. If the execution content has not changed, you can specify only stateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terraform {
        ///   required_providers {
        ///     alicloud = {
        ///       source   = &quot;aliyun/alicloud&quot;
        ///       version  = &quot;1.254.0&quot;
        ///     }
        ///   }
        /// }</para>
        /// <para>resource &quot;alicloud_vpc&quot; &quot;default&quot; {
        ///   is_default                                  = false
        ///   enable_ipv6                                 = false
        ///   classic_link_enabled                        = false
        ///   force_delete                                = false
        ///   system_route_table_route_propagation_enable = false
        ///   dry_run                                     = false
        /// }</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The state file ID. If this parameter is specified, the Apply command continues execution based on the existing state file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-xxx</para>
        /// </summary>
        [NameInMap("stateId")]
        [Validation(Required=false)]
        public string StateId { get; set; }

    }

}
