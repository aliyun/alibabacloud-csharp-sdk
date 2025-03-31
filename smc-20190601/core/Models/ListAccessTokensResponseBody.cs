// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class ListAccessTokensResponseBody : TeaModel {
        /// <summary>
        /// <para>The activation codes returned.</para>
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
                /// <para>The ID of the activation code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>at-bp1akz2zp67r0k6r****</para>
                /// </summary>
                [NameInMap("AccessTokenId")]
                [Validation(Required=false)]
                public string AccessTokenId { get; set; }

                /// <summary>
                /// <para>The maximum number of times that the activation code can be used. Valid values: 1 to 1000.</para>
                /// <para>Default value: 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// <para>The time when the activation code was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-09T02:35:44Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the activation code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is an activation code</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the activation code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of migration sources whose information has been imported to Server Migration Center (SMC) by using the activation code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RegisteredCount")]
                [Validation(Required=false)]
                public string RegisteredCount { get; set; }

                /// <summary>
                /// <para>The status of the activation code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>activated</description></item>
                /// <item><description>unactivated</description></item>
                /// <item><description>expired</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>activated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The validity period of the activation code. Unit: day. Valid values: 1 to 90. Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("TimeToLiveInDays")]
                [Validation(Required=false)]
                public string TimeToLiveInDays { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>10</description></item>
        /// <item><description>20</description></item>
        /// <item><description>50</description></item>
        /// </list>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2DA3097-79B9-53AE-B0DF-281DC54F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of migration sources returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
