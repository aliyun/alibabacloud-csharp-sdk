// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListManifestEditTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. Default value: <b>30</b>. Valid values: <b>1</b> to <b>200</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination cursor. You do not need to specify this parameter for the first call. The value is a string in the format of page_N, where N is the page number. Pass the NextToken value returned in the previous response to retrieve the next page. If no NextToken is returned in the response, all data has been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>page_2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
