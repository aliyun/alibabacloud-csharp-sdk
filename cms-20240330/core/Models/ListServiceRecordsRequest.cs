// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListServiceRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the linked entry. Currently supported:
        /// logCorrelation, which indicates application log association.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logCorrelation</para>
        /// </summary>
        [NameInMap("recordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        /// <summary>
        /// <para>The filter information for service-linked entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;serviceName&quot;: &quot;my-service&quot;,
        ///   &quot;storeName&quot;: &quot;my-logstore&quot;
        /// }</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

    }

}
