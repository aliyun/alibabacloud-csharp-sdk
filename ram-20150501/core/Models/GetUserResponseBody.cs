// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF5189484043</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the RAM user.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The description of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud computing engineer</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The point in time when the RAM user was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The display name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The email address of the RAM user.</para>
            /// <remarks>
            /// <para> This parameter can be returned only on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The point in time when the RAM user last logged on to the Alibaba Cloud Management Console by using the password. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("LastLoginDate")]
            [Validation(Required=false)]
            public string LastLoginDate { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the RAM user.</para>
            /// <remarks>
            /// <para> This parameter can be returned only on the China site (aliyun.com).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86-1860000****</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <para>The point in time when the information about the RAM user was last modified. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-02-11T03:15:21Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The ID of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222748924538****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
