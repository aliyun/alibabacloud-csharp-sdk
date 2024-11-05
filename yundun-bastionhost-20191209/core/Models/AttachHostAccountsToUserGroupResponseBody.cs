// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachHostAccountsToUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachHostAccountsToUserGroupResponseBodyResults> Results { get; set; }
        public class AttachHostAccountsToUserGroupResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The return code that indicates whether the call was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OK</b>: The call was successful.</description></item>
            /// <item><description><b>UNEXPECTED</b>: An unknown error occurred.</description></item>
            /// <item><description><b>INVALID_ARGUMENT</b>: A request parameter is invalid.</description></item>
            /// <item><description><b>OBJECT_NOT_FOUND</b>: The specified object on which you want to perform the operation does not exist.</description></item>
            /// <item><description><b>OBJECT_AlREADY_EXISTS</b>: The specified object on which you want to perform the operation already exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The result of authorizing the specified user group to manage the specified host accounts.</para>
            /// </summary>
            [NameInMap("HostAccounts")]
            [Validation(Required=false)]
            public List<AttachHostAccountsToUserGroupResponseBodyResultsHostAccounts> HostAccounts { get; set; }
            public class AttachHostAccountsToUserGroupResponseBodyResultsHostAccounts : TeaModel {
                /// <summary>
                /// <para>The return code that indicates whether the user group was authorized to manage the specified host account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: The call was successful.</description></item>
                /// <item><description><b>UNEXPECTED</b>: An unknown error occurred.</description></item>
                /// <item><description><b>INVALID_ARGUMENT</b>: A request parameter is invalid.</description></item>
                /// <item><description><b>OBJECT_NOT_FOUND</b>: The specified object on which you want to perform the operation does not exist.</description></item>
                /// <item><description><b>OBJECT_AlREADY_EXISTS</b>: The specified object on which you want to perform the operation already exists.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The ID of the host account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HostAccountId")]
                [Validation(Required=false)]
                public string HostAccountId { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The ID of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
