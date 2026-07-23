// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CheckServiceLinkedRoleForProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of \<c>Success\\</c> indicates that the request is successful. For more information about other error codes, see Error codes.</para>
        /// <para>Success: The request is successful.</para>
        /// <para>Other codes indicate that the request failed. For more information about error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckServiceLinkedRoleForProductResponseBodyData Data { get; set; }
        public class CheckServiceLinkedRoleForProductResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service-linked role exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CheckPass")]
            [Validation(Required=false)]
            public bool? CheckPass { get; set; }

            /// <summary>
            /// <para>The name of the service-linked role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunServiceRoleForEventBridgeConnectVPC</para>
            /// </summary>
            [NameInMap("StsRoleName")]
            [Validation(Required=false)]
            public string StsRoleName { get; set; }

        }

        /// <summary>
        /// <para>The returned message. If the request is successful, \<c>Success\\</c> is returned. If the request fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. \<c>true\\</c>: The request was successful. \<c>false\\</c>: The request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
