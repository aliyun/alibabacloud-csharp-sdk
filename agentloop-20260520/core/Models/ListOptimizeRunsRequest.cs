// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListOptimizeRunsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The lower bound of the window start time in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786432688000</para>
        /// </summary>
        [NameInMap("windowStartTimeBegin")]
        [Validation(Required=false)]
        public long? WindowStartTimeBegin { get; set; }

        /// <summary>
        /// <para>The upper bound of the window start time in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786432690000</para>
        /// </summary>
        [NameInMap("windowStartTimeEnd")]
        [Validation(Required=false)]
        public long? WindowStartTimeEnd { get; set; }

    }

}
