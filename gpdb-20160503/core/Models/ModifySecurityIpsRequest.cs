// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifySecurityIpsRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the IP address whitelist. By default, this parameter is empty. A whitelist with the <c>hidden</c> attribute does not appear in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the whitelist. If you do not enter a name, IP addresses are added to the default whitelist.</para>
        /// <remarks>
        /// <para> You can create up to 50 whitelists for an instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DBInstanceIPArrayName")]
        [Validation(Required=false)]
        public string DBInstanceIPArrayName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the instance IDs of all AnalyticDB for PostgreSQL instances in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The method of modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b>: overwrites the whitelist.</description></item>
        /// <item><description><b>Append</b>: appends data to the whitelist.</description></item>
        /// <item><description><b>Delete</b>: deletes the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. For more information about how to obtain the ID of a resource group, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IP addresses listed in the whitelist. You can add up to 1,000 IP addresses to the whitelist. Separate multiple IP addresses with commas (,). The IP addresses must use one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>0.0.0.0/0</description></item>
        /// <item><description>10.23.12.24. This is a standard IP address.</description></item>
        /// <item><description>10.23.12.24/24. This is a CIDR block. The value <c>/24</c> indicates that the prefix of the CIDR block is 24-bit long. You can replace 24 with a value in the range of <c>1 to 32</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.10.**.**</c></para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

    }

}
