// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeWhiteRuleListRequest : TeaModel {
        /// <summary>
        /// <para>The alert name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Try SNMP weak password</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The alert type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scan</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The universally unique identifier (UUID) of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is deployed. You must select the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are deployed in the Chinese mainland or in the China (Hong Kong) region.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are deployed in regions outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member. This parameter is used in a multi-account management scenario. An administrator can specify this parameter to query the data of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all accounts that are managed by the administrator account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
