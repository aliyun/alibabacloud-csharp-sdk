// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeMajorProtectionBlackIpsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address that you want to query. You can specify this parameter to query an IP address in the IP address blacklist for major event protection by using fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("IpLike")]
        [Validation(Required=false)]
        public string IpLike { get; set; }

        /// <summary>
        /// <para>The method that you want to use to sort the IP addresses <b>in descending order</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>gmtModified:</b> sorts the IP addresses by most recent modification time.</description></item>
        /// <item><description><b>ip:</b> sorts the IP addresses by IP address.</description></item>
        /// <item><description><b>templateId:</b> sorts the IP addresses by template ID.</description></item>
        /// <item><description><b>id:</b> sorts the IP addresses by primary key.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gmtModified</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou:</b> the Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1:</b> outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the IP address blacklist rule for major event protection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20013199</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The ID of the rule template for major event protection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5673</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
