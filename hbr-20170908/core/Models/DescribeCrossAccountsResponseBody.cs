// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeCrossAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CrossAccounts")]
        [Validation(Required=false)]
        public DescribeCrossAccountsResponseBodyCrossAccounts CrossAccounts { get; set; }
        public class DescribeCrossAccountsResponseBodyCrossAccounts : TeaModel {
            [NameInMap("CrossAccount")]
            [Validation(Required=false)]
            public List<DescribeCrossAccountsResponseBodyCrossAccountsCrossAccount> CrossAccount { get; set; }
            public class DescribeCrossAccountsResponseBodyCrossAccountsCrossAccount : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CROSS_ACCOUNT</para>
                /// </summary>
                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
