// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAttachInfoRequest : TeaModel {
        /// <summary>
        /// <para>The list of KvcsIds of the KVCacheStores to query. You can specify up to 100 KvcsIds.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KvcsIds")]
        [Validation(Required=false)]
        public List<string> KvcsIds { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a single call. Valid values: 1 to 500.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned from the last call to this operation. You do not need to specify this parameter for the first call. If NextToken is specified, the PageSize and PageNumber request parameters become invalid, and the TotalCount value in the response is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-client-token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number for a paging query. This parameter is used together with PageSize. If the specified page number exceeds the total number of pages, the last page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paging query.</para>
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

        /// <summary>
        /// <para>The ID of the compute-side VSC. If you specify this parameter, the mount records are filtered by the specified VSC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsc-dhag651dsda</para>
        /// </summary>
        [NameInMap("VscId")]
        [Validation(Required=false)]
        public string VscId { get; set; }

    }

}
