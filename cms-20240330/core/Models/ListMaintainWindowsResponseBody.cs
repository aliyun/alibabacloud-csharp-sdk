// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListMaintainWindowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of silence policies. An empty list is returned if no matches are found. List items do not include workspaceFilterSetting.</para>
        /// </summary>
        [NameInMap("maintainWindowList")]
        [Validation(Required=false)]
        public List<MaintainWindowForView> MaintainWindowList { get; set; }

        /// <summary>
        /// <para>The maximum number of records returned for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The starting cursor for the next page. If this value is not empty, you can continue to query, but the next page may still be empty. An empty value indicates the end of pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y21zRXZlbnRCYXNlUGFnZT0y</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique ID of the request, which is used for troubleshooting and ticket tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A0D1C36</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
