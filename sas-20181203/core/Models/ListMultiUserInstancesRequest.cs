// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListMultiUserInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The number of rows per page for paging. The maximum value is 100. Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Used for paging. Leave this parameter empty for the first request. For subsequent requests, specify the NextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAB4SwmEAAAAACjMDLgAAADFTNzMyZDMwMzAzMDM0NzY3YTZjNjI3NjZmNmU3MjcxNjk3NDY5MzY3MjY4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
