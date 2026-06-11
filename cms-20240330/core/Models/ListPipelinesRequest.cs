// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPipelinesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return. The service may return fewer results than the specified value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. If this parameter is not empty, use it in a subsequent request to get the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fff3442dac1de7950f44d5afc0c735ebd12e27f603b21d17ec30cb1d5c735b1ba7c4fb3a1c124bce</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pipeline name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pipeline-name-1</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

    }

}
