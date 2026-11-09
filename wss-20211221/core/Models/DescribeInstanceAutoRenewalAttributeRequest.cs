// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeInstanceAutoRenewalAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The auto-renewal status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Auto-renewal is enabled.</description></item>
        /// <item><description>false: Auto-renewal is disabled.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The list of instance IDs for which to query the auto-renewal status.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The mark for paging. Leave this parameter empty for the first query. For subsequent paging, pass the NextToken value returned in the previous response as is. Do not construct or decode the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Maximum value: 500. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource type. Example: CorePackage indicates a core-hour package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CorePackage</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of resource types.</para>
        /// </summary>
        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public List<string> ResourceTypeList { get; set; }

        /// <summary>
        /// <para>The region ID used to filter instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

    }

}
