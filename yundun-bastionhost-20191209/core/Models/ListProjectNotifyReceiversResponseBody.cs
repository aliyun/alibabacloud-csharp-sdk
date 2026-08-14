// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListProjectNotifyReceiversResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of recipients.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListProjectNotifyReceiversResponseBodyItems> Items { get; set; }
        public class ListProjectNotifyReceiversResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The email address of the recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6291****@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The name of the recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The phone number of the recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****6412</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The ID of the notification recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ReceiverId")]
            [Validation(Required=false)]
            public string ReceiverId { get; set; }

        }

        /// <summary>
        /// <para>The value of the MaxResults request parameter passed in the request if a valid parameter value was specified. Otherwise, the default value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next request. Use this value for the NextToken request parameter in the next paged query. If this field is empty in the response, no more data is available. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ieSWJCwxvW3dk3wF.BqkrZmP72nWu5zJ5NWydMqyEs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81500666-d7f5-4143-8329-0223cc738105</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of recipients returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
