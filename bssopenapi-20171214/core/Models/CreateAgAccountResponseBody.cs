// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateAgAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The level 2 relationship between the master account (MPK) and the member account (PK).</para>
        /// </summary>
        [NameInMap("AgRelationDto")]
        [Validation(Required=false)]
        public CreateAgAccountResponseBodyAgRelationDto AgRelationDto { get; set; }
        public class CreateAgAccountResponseBodyAgRelationDto : TeaModel {
            /// <summary>
            /// <para>The UID of the master account (MPK).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785287436011964</para>
            /// </summary>
            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public string Mpk { get; set; }

            /// <summary>
            /// <para>The UID of the member account (PK) that is managed by the master account (MPK).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1728240534507590</para>
            /// </summary>
            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            /// <summary>
            /// <para>The name of the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin-role</para>
            /// </summary>
            [NameInMap("RamAdminRoleName")]
            [Validation(Required=false)]
            public string RamAdminRoleName { get; set; }

            /// <summary>
            /// <para>The type of the account linking relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINACE_CLOUD</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOGIN_EMAIL_HAS_BEEN_USED</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loginEmail=<a href="mailto:685741089H@chinaunicom.cn">685741089H@chinaunicom.cn</a>,has used</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAE08A27-386C-579E-966D-8853EC3C5D0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
