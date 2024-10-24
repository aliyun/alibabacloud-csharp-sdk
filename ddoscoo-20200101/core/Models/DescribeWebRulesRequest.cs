// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebRulesRequest : TeaModel {
        /// <summary>
        /// <para>The CNAME address to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kzmk7b8tt351****.aliyunddos1014****</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>The domain name of the website to query.</para>
        /// <remarks>
        /// <para>The domain must have been configured with website business forwarding rules. You can call <a href="~~DescribeDomains~~">DescribeDomains</a> to query all domains that have been configured with website business forwarding rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The list of DDoS protection instance IDs to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query matching pattern. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>fuzzy</b> (default): Indicates fuzzy query.</description></item>
        /// <item><description><b>exact</b>: Indicates exact query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exact</para>
        /// </summary>
        [NameInMap("QueryDomainPattern")]
        [Validation(Required=false)]
        public string QueryDomainPattern { get; set; }

        /// <summary>
        /// <para>The resource group ID of the DDoS protection instance in the resource management service.</para>
        /// <para>Not setting this parameter indicates the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
