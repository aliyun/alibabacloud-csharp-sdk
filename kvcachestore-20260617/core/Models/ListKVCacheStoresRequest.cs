// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoresRequest : TeaModel {
        /// <summary>
        /// <para>The list of KvcsIds. Separate multiple IDs with commas. You can specify up to 100 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvcs-87djda131</para>
        /// </summary>
        [NameInMap("KvcsIds")]
        [Validation(Required=false)]
        public string KvcsIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for cursor pagination. Default value: 10. Maximum value: 100. This parameter is used together with NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The instance name filter for prefix matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>obj-detect</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination cursor. Do not specify this parameter for the first query. For subsequent queries, use the NextToken value returned from the previous request. This parameter and PageNumber are mutually exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a24c3a9cc8e6da77b10cffc4c93c7922e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. This parameter and NextToken are mutually exclusive. If both are specified, PageNumber takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100. This parameter is used together with PageNumber.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID, such as cn-hangzhou.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance status filter. Valid values: Creating, Available, InUse, Stopping, Stopped, and Deleting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The zone ID, such as cn-hangzhou-a.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
