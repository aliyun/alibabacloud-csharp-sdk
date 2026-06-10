// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateAlertDestinationResponseBody : TeaModel {
        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateAlertDestinationResponseBodyData Data { get; set; }
        public class CreateAlertDestinationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753669116286</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>Policy ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>Policy Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>SysOM</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Configuration Parameter of alert contact</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public CreateAlertDestinationResponseBodyDataParams Params { get; set; }
            public class CreateAlertDestinationResponseBodyDataParams : TeaModel {
                /// <summary>
                /// <para>mailbox</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:xxx@email.com">xxx@email.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>Phone</para>
                /// 
                /// <b>Example:</b>
                /// <para>1xxx</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>Robot key</para>
                /// 
                /// <b>Example:</b>
                /// <para>SECxxx</para>
                /// </summary>
                [NameInMap("sec")]
                [Validation(Required=false)]
                public string Sec { get; set; }

                /// <summary>
                /// <para>Robot address</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxx">https://oapi.dingtalk.com/robot/send?access_token=xxx</a></para>
                /// </summary>
                [NameInMap("webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

            /// <summary>
            /// <para>Configuration Source</para>
            /// 
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Push Target. Currently, only DingTalk Robot is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1222933234714935</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>Update Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1751254826285</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIException: SysomOpenAPI.InvalidParameter Invalid params, should be json string or dict</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
