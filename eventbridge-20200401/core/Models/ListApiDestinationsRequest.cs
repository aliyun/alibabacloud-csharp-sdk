// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListApiDestinationsRequest : TeaModel {
        /// <summary>
        /// The prefix of the API destination name.
        /// </summary>
        [NameInMap("ApiDestinationNamePrefix")]
        [Validation(Required=false)]
        public string ApiDestinationNamePrefix { get; set; }

        /// <summary>
        /// The connection name.
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// The maximum number of entries to be returned in a call. You can use this parameter and NextToken to implement paging.
        /// 
        /// *   Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// If you set Limit and excess return values exist, this parameter is returned.
        /// 
        /// *   Default value: 0.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
