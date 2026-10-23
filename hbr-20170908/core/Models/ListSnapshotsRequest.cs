// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class ListSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>The end completion time. The value is a UNIX timestamp in seconds. Only backup points whose completion time is less than this value are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1776059382</para>
        /// </summary>
        [NameInMap("CompleteTimeEnd")]
        [Validation(Required=false)]
        public long? CompleteTimeEnd { get; set; }

        /// <summary>
        /// <para>The start completion time. The value is a UNIX timestamp in seconds. Only backup points whose completion time is greater than or equal to this value are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1776059082</para>
        /// </summary>
        [NameInMap("CompleteTimeStart")]
        [Validation(Required=false)]
        public long? CompleteTimeStart { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for a paged query. Default value: 10. The value must be greater than 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. You do not need to specify this parameter for the first query. When you query the next page, set this parameter to the <b>NextToken</b> value returned from the previous page. If <b>NextToken</b> is empty, no more pages exist. This parameter cannot be used together with <b>Skip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJJbmRleCI6NjUwMX0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan. This is an optional filter. If you specify this parameter, only the backup points under the specified backup plan are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-0000****123</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The ID of the protected resource. The protected resource must exist, and its data source type must be the same as the value of the <b>SourceType</b> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pr-123***7890</para>
        /// </summary>
        [NameInMap("ProtectedResourceId")]
        [Validation(Required=false)]
        public string ProtectedResourceId { get; set; }

        /// <summary>
        /// <para>The number of entries to skip. The value must be a non-negative integer and a multiple of <b>MaxResults</b>. This parameter cannot be used together with <b>NextToken</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// <para>The data source type. It must be the same as the data source type of the protected resource specified by ProtectedResourceId. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The ID of the vault. This is an optional filter. If you specify this parameter, only the backup points in the specified vault are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-00030j3c******sn</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
