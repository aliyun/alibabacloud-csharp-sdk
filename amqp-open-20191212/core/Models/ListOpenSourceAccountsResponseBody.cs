// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListOpenSourceAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOpenSourceAccountsResponseBodyData> Data { get; set; }
        public class ListOpenSourceAccountsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678900123</para>
            /// </summary>
            [NameInMap("AliyunUserId")]
            [Validation(Required=false)]
            public long? AliyunUserId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amqp-abc***</para>
            /// </summary>
            [NameInMap("CInstanceId")]
            [Validation(Required=false)]
            public string CInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the user was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704067200000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtraJson")]
            [Validation(Required=false)]
            public string ExtraJson { get; set; }

            /// <summary>
            /// <para>The hash algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bcrypt</para>
            /// </summary>
            [NameInMap("HashingAlgorithm")]
            [Validation(Required=false)]
            public string HashingAlgorithm { get; set; }

            /// <summary>
            /// <para>The quota configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Limits")]
            [Validation(Required=false)]
            public string Limits { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The password hash.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f6af6bbb91e947d988d191bfe01c9a9b</para>
            /// </summary>
            [NameInMap("PasswordHash")]
            [Validation(Required=false)]
            public string PasswordHash { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>Indicates whether the password is a weak password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("WeakPassword")]
            [Validation(Required=false)]
            public bool? WeakPassword { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token that marks the end of the current query. This token is passed as a parameter in the next call to continue pagination. Set this parameter to an empty string for the first call or when the last page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>021788F6-E50C-4BD6-9F80-66B0A19A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
