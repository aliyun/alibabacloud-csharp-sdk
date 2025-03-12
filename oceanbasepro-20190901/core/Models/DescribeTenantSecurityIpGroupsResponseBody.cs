// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantSecurityIpGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469**-AA6F-4D**-B3DB-A***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of the whitelist groups.</para>
        /// </summary>
        [NameInMap("SecurityIpGroups")]
        [Validation(Required=false)]
        public List<DescribeTenantSecurityIpGroupsResponseBodySecurityIpGroups> SecurityIpGroups { get; set; }
        public class DescribeTenantSecurityIpGroupsResponseBodySecurityIpGroups : TeaModel {
            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            /// <summary>
            /// <para>The whitelist group type.</para>
            /// <list type="bullet">
            /// <item><description>instance: the whitelist group from the cluster.</description></item>
            /// <item><description>tenant: the whitelist group of the current tenant.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tenant</para>
            /// </summary>
            [NameInMap("SecurityIpGroupType")]
            [Validation(Required=false)]
            public string SecurityIpGroupType { get; set; }

            /// <summary>
            /// <para>The whitelist of IP addresses. It is a string separated by commas, and each object is an IP string or a CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.***.<em>.</em>&quot;</para>
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t4louaeei****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>The total number of the whitelist groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
