// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2022-08-31T06:56:45Z&quot;</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xianqiu</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;asdfdfsdfsdfds&quot;</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the session.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: single-session</description></item>
        /// <item><description>1: multi-session</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public int? OwnType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The status of the session.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Connected</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Disconnected</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Connected</para>
        /// </summary>
        [NameInMap("SessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2022-08-31T06:56:45Z&quot;</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
