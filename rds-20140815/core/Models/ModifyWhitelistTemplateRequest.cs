// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyWhitelistTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The IP whitelist of the instance. Separate multiple IP addresses with commas (,). IP addresses cannot be duplicated. The following two formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address format, such as 10.23.XX.XX.</description></item>
        /// <item><description>CIDR format, such as 10.23.XX.XX/24 (Classless Inter-Domain Routing, where 24 indicates the prefix length, with a value range of 1 to 32).</description></item>
        /// </list>
        /// <remarks>
        /// <para>Each instance supports a maximum of 1,000 IP addresses or CIDR blocks. The total number of IP addresses or CIDR blocks across all IP whitelist groups cannot exceed 1,000. If you have a large number of IP addresses, merge them into CIDR blocks, such as 10.23.XX.XX/24.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139.196.X.X,101.132.X.X</para>
        /// </summary>
        [NameInMap("IpWhitelist")]
        [Validation(Required=false)]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see What is a resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The whitelist template ID.
        /// This parameter is required for modify and delete operations. You can call DescribeAllWhitelistTemplate to obtain the template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>539</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// <para>The whitelist template name. Specify this parameter when creating a template. The name cannot be modified after creation, must be unique within the same account, and must start with a letter. You can call DescribeWhitelistTemplate to obtain the template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template_123</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
