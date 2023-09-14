// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAScriptsRequest : TeaModel {
        /// <summary>
        /// The AScript rule IDs.
        /// </summary>
        [NameInMap("AScriptIds")]
        [Validation(Required=false)]
        public List<string> AScriptIds { get; set; }

        /// <summary>
        /// The names of the AScript rules.
        /// </summary>
        [NameInMap("AScriptNames")]
        [Validation(Required=false)]
        public List<string> AScriptNames { get; set; }

        /// <summary>
        /// The listener IDs.
        /// </summary>
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

        /// <summary>
        /// The maximum number of entries to return.
        /// 
        /// Valid values: **1** to **100**.
        /// 
        /// Default value: **20**. If you do not specify this parameter, the default value is used.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.****
        /// *   You must specify the token that is obtained from the previous query as the value of **NextToken**.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
