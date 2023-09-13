// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListConnectionsRequest : TeaModel {
        /// <summary>
        /// The key word that you specify to query connections. Connections can be queried by prefixes.
        /// </summary>
        [NameInMap("ConnectionNamePrefix")]
        [Validation(Required=false)]
        public string ConnectionNamePrefix { get; set; }

        /// <summary>
        /// The maximum number of entries to be returned in a single call. You can use this parameter and the NextToken parameter to implement paging.
        /// 
        /// *   Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// If you set the Limit parameter and excess return values exist, this parameter is returned.
        /// 
        /// *   Default value: 0.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
