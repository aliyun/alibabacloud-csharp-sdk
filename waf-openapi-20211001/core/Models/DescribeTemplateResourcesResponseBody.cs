// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeTemplateResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page. Valid values: 1 to 500. Default value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. This parameter is returned if a next page exists.</para>
        /// <remarks>
        /// <para>If a value is returned for this parameter, a next page exists. You can use the returned <b>NextToken</b> value as a request parameter to retrieve the data on the next page. When no value is returned, all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAABLQv******37sHZaHk4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7BC9373-3960-53B0-8968-2B13454AE18F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of the names of the attached protected objects or protected object groups, or the IDs of the protected assets.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

        /// <summary>
        /// <para>The ID of the protection template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>168465</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
