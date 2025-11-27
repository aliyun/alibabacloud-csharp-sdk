// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeGroupUserResponseBody : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para> This field is deprecated.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeGroupUserResponseBodyGroups> Groups { get; set; }
        public class DescribeGroupUserResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The user group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ug-91mvbosdjsdfh****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the user group.</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The number of members in the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public string UserCount { get; set; }

        }

        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, all results have been queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA8D67CB-345D-5CDA-986E-FFAC7D0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The members.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeGroupUserResponseBodyUsers> Users { get; set; }
        public class DescribeGroupUserResponseBodyUsers : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para> This field is deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>xx-xx-xx</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This field is deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://avatar.****.com">https://avatar.****.com</a></para>
            /// </summary>
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alex****@aliyun.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The user name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alex****</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The time when the user was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-26T02:59:22.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the user was added to the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-26T02:59:22.000+00:00</para>
            /// </summary>
            [NameInMap("GmtJoinGroup")]
            [Validation(Required=false)]
            public string GmtJoinGroup { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This field is deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("JobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alex</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The mobile number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188888****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The remarks on the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
