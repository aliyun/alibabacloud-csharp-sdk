// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeSaslUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3B3592-5994-4F65-A61E-E62A77A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SaslUserList")]
        [Validation(Required=false)]
        public DescribeSaslUsersResponseBodySaslUserList SaslUserList { get; set; }
        public class DescribeSaslUsersResponseBodySaslUserList : TeaModel {
            [NameInMap("SaslUserVO")]
            [Validation(Required=false)]
            public List<DescribeSaslUsersResponseBodySaslUserListSaslUserVO> SaslUserVO { get; set; }
            public class DescribeSaslUsersResponseBodySaslUserListSaslUserVO : TeaModel {
                [NameInMap("Mechanism")]
                [Validation(Required=false)]
                public string Mechanism { get; set; }

                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
