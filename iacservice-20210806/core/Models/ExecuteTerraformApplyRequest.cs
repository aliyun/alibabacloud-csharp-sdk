// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ExecuteTerraformApplyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>task-xxx</para>
        /// </summary>
        [NameInMap("stateId")]
        [Validation(Required=false)]
        public string StateId { get; set; }

    }

}
