// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ListAccessTokensResponseBody : TeaModel {
        /// <summary>
        /// The activation codes returned.
        /// </summary>
        [NameInMap("AccessTokens")]
        [Validation(Required=false)]
        public ListAccessTokensResponseBodyAccessTokens AccessTokens { get; set; }
        public class ListAccessTokensResponseBodyAccessTokens : TeaModel {
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public List<ListAccessTokensResponseBodyAccessTokensAccessToken> AccessToken { get; set; }
            public class ListAccessTokensResponseBodyAccessTokensAccessToken : TeaModel {
                /// <summary>
                /// The ID of the activation code.
                /// </summary>
                [NameInMap("AccessTokenId")]
                [Validation(Required=false)]
                public string AccessTokenId { get; set; }

                /// <summary>
                /// The maximum number of times that the activation code can be used. Valid values: 1 to 1000.
                /// 
                /// Default value: 100.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// The time when the activation code was created. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the activation code.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the activation code.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The number of migration sources whose information has been imported to Server Migration Center (SMC) by using the activation code.
                /// </summary>
                [NameInMap("RegisteredCount")]
                [Validation(Required=false)]
                public string RegisteredCount { get; set; }

                /// <summary>
                /// The status of the activation code. Valid values:
                /// 
                /// *   activated
                /// *   unactivated
                /// *   expired
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The validity period of the activation code. Unit: day. Valid values: 1 to 90. Default value: 30.
                /// </summary>
                [NameInMap("TimeToLiveInDays")]
                [Validation(Required=false)]
                public string TimeToLiveInDays { get; set; }

            }

        }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   10
        /// *   20
        /// *   50
        /// 
        /// Default value: 20.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of migration sources returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
