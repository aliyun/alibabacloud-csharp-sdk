// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantSecurityIpGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The group name of the whitelist group of IP addresses.</para>
        /// <para>It starts with lowercase letters and ends with lowercase letters or numbers. It can only contain lowercase letters, numbers, and underscores, and should be 2~32 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paytest</para>
        /// </summary>
        [NameInMap("SecurityIpGroupName")]
        [Validation(Required=false)]
        public string SecurityIpGroupName { get; set; }

        /// <summary>
        /// <para>The list of IP addresses in the whitelist group.</para>
        /// <para>It is a JSON array. Each object in the array is an IP address or a CIDR block. You can have up to 40 whitelists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.***.<em>.</em>&quot;</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t4louaeei****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
