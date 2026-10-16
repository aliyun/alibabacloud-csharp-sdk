// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListUserPoolsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 1 to 1000. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to query the next page of data. You do not need to specify this parameter for the first call. If a NextToken is returned in the response of the previous call, specify it in the current call to obtain the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFVzZXJQb29sczo6MTA=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
