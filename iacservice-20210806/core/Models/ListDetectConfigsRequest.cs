// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListDetectConfigsRequest : TeaModel {
        /// <summary>
        /// <para>Name of the drift detection configuration (fuzzy match).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("detectConfigName")]
        [Validation(Required=false)]
        public string DetectConfigName { get; set; }

        /// <summary>
        /// <para>Maximum number of records to retrieve in a single request. Valid range: 1–200. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Query credential (Token). Set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30BaZ9ekYWXJdqshYecA++coNg7qT1Zbm3RfLyFIZeY=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
