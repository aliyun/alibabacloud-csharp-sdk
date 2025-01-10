// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVccGrantRulesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable paged query. Optional values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable pagination query</description></item>
        /// <item><description><b>false</b>: Pagination query is disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePage")]
        [Validation(Required=false)]
        public bool? EnablePage { get; set; }

        /// <summary>
        /// <para>Lingjun HUB ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>Use the drop-down box</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForSelect")]
        [Validation(Required=false)]
        public bool? ForSelect { get; set; }

        /// <summary>
        /// <para>Authorization Entry ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>grant-rule-jaj33d1b804</para>
        /// </summary>
        [NameInMap("GrantRuleId")]
        [Validation(Required=false)]
        public string GrantRuleId { get; set; }

        /// <summary>
        /// <para>Authorized Tenant ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620939556166277</para>
        /// </summary>
        [NameInMap("GrantTenantId")]
        [Validation(Required=false)]
        public string GrantTenantId { get; set; }

        /// <summary>
        /// <para>Network Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-jaj33d1b804</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Instance name</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzb3n5lgk2ieq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
