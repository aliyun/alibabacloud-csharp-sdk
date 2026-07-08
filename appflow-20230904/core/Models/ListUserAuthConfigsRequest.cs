// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class ListUserAuthConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The authentication type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QQBotAccessToken</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The ID of the connector.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-88d2c03da8c9410e8a91</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The version of the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("ConnectorVersion")]
        [Validation(Required=false)]
        public string ConnectorVersion { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListUserAuthConfigsRequestFilter> Filter { get; set; }
        public class ListUserAuthConfigsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AuthConfigName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of filter values. The valid range for N is 1 to 10.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAVY3rYiv9VoUJQSiCitgjgQu5rMgGgvUoNWg8LykhA85j8bgHiGAwZWnCMJPepC+WWc0DK5hx1qIycMHVWP2AjQ=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
