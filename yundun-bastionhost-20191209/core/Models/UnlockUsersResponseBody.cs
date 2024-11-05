// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class UnlockUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of information about the result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<UnlockUsersResponseBodyResults> Results { get; set; }
        public class UnlockUsersResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The result of the call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>OK</b>: The call was successful.</para>
            /// </description></item>
            /// <item><description><para><b>UNEXPECTED</b>: An unknown error occurred.</para>
            /// </description></item>
            /// <item><description><para><b>INVALID_ARGUMENT</b>: A request parameter is invalid.</para>
            /// <para>**</para>
            /// <para><b>Note</b>Make sure that the request parameters are valid and call the operation again.</para>
            /// </description></item>
            /// <item><description><para><b>OBJECT_NOT_FOUND</b>: The specified object on which you want to perform the operation does not exist.</para>
            /// <para>**</para>
            /// <para><b>Note</b>Check whether the specified ID of the bastion host exists, whether the specified hosts exist, and whether the specified host IDs are valid. Then, call the operation again.</para>
            /// </description></item>
            /// <item><description><para><b>OBJECT_AlREADY_EXISTS</b>: The specified object on which you want to perform the operation already exists.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

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
            /// <para>１</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
