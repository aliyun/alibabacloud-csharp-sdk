// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowCooperatorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The users that are involved in the task flow.</para>
        /// </summary>
        [NameInMap("CooperatorList")]
        [Validation(Required=false)]
        public ListTaskFlowCooperatorsResponseBodyCooperatorList CooperatorList { get; set; }
        public class ListTaskFlowCooperatorsResponseBodyCooperatorList : TeaModel {
            [NameInMap("Cooperator")]
            [Validation(Required=false)]
            public List<ListTaskFlowCooperatorsResponseBodyCooperatorListCooperator> Cooperator { get; set; }
            public class ListTaskFlowCooperatorsResponseBodyCooperatorListCooperator : TeaModel {
                /// <summary>
                /// <para>The email address of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@XX.com">test@XX.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                /// <summary>
                /// <para>The alias of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>userId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54C99C70-2DFF-5A8C-A252-EBAA1EB668EC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
