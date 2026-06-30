// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <c>200</c> indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataUser> User { get; set; }
            public class ListUsersResponseBodyDataUser : TeaModel {
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LoginUserType")]
                [Validation(Required=false)]
                public int? LoginUserType { get; set; }

                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned. The value is successful if the request is successful. Otherwise, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries displayed per page.</para>
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
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates success. A value of false or null indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
