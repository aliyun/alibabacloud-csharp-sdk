// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAttachInfoRequest : TeaModel {
        /// <summary>
        /// <para>The list of KVCacheStore KvcsId values to query. A maximum of 100 values can be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KvcsIds")]
        [Validation(Required=false)]
        public List<string> KvcsIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a single request. Valid values: 1 to 500.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous call. You do not need to set this parameter for the first request. If you set NextToken, the PageSize and PageNumber request parameters become ineffective, and the TotalCount value in the response is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-client-token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number for a paged query. Used together with PageSize. If the value exceeds the total number of pages, the last page of data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
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

    }

}
