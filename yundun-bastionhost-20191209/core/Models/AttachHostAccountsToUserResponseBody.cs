// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachHostAccountsToUserResponseBody : TeaModel {
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
        /// <para>The results of the API call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachHostAccountsToUserResponseBodyResults> Results { get; set; }
        public class AttachHostAccountsToUserResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The result of the API call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>OK</b>: The operation is successful.</para>
            /// </description></item>
            /// <item><description><para><b>UNEXPECTED</b>: An unknown error occurred.</para>
            /// </description></item>
            /// <item><description><para><b>INVALID_ARGUMENT</b>: A request parameter is invalid.</para>
            /// <remarks>
            /// <para>Check the request parameters, ensure that they are correct, and then call the operation again.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><b>OBJECT_NOT_FOUND</b>: The object on which the operation is performed does not exist.</para>
            /// <remarks>
            /// <para>Check whether the ID of the Bastionhost instance exists, whether the host exists, and whether the host ID is correct, and then call the operation again.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description><para><b>OBJECT_AlREADY_EXISTS</b>: The object on which the operation is performed already exists.</para>
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
            /// <para>The results returned for the operation of authorizing host accounts for the user.</para>
            /// </summary>
            [NameInMap("HostAccounts")]
            [Validation(Required=false)]
            public List<AttachHostAccountsToUserResponseBodyResultsHostAccounts> HostAccounts { get; set; }
            public class AttachHostAccountsToUserResponseBodyResultsHostAccounts : TeaModel {
                /// <summary>
                /// <para>The result returned for the operation of authorizing host accounts for the user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: The operation is successful.</description></item>
                /// <item><description><b>UNEXPECTED</b>: An unknown error occurred.</description></item>
                /// <item><description><b>INVALID_ARGUMENT</b>: A request parameter is invalid.</description></item>
                /// <item><description><b>OBJECT_NOT_FOUND</b>: The object on which the operation is performed does not exist.</description></item>
                /// <item><description><b>OBJECT_AlREADY_EXISTS</b>: The object on which the operation is performed already exists.</description></item>
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
                /// <para><b>[Deprecated]</b> This parameter is deprecated. You can ignore it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
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
            /// <para><b>[Deprecated]</b> This parameter is deprecated. You can ignore it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
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
