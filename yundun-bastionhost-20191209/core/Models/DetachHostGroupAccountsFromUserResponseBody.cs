// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostGroupAccountsFromUserResponseBody : TeaModel {
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
        public List<DetachHostGroupAccountsFromUserResponseBodyResults> Results { get; set; }
        public class DetachHostGroupAccountsFromUserResponseBodyResults : TeaModel {
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
            /// <para>The result of revoking permissions on the specified host accounts from the user.</para>
            /// </summary>
            [NameInMap("HostAccountNames")]
            [Validation(Required=false)]
            public List<DetachHostGroupAccountsFromUserResponseBodyResultsHostAccountNames> HostAccountNames { get; set; }
            public class DetachHostGroupAccountsFromUserResponseBodyResultsHostAccountNames : TeaModel {
                /// <summary>
                /// <para>The return code that indicates whether permissions on the specified host account were revoked from the user. Valid values:</para>
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
                /// <para>The name of the host account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("HostAccountName")]
                [Validation(Required=false)]
                public string HostAccountName { get; set; }

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
            /// <para>The ID of the host group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

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
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
