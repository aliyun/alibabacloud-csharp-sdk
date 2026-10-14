// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeStsGrantStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Proxy instance belongs in Resource Management.</para>
        /// <para>If you do not specify this parameter, the default resource group is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that you want to query. The value is fixed as <b>AliyunDDoSCOODefaultRole</b>, which indicates the default role of Anti-DDoS Proxy.</para>
        /// <remarks>
        /// <para>Anti-DDoS Proxy use this role by default to access your resources in other cloud services.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunDDoSCOODefaultRole</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
