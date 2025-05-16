// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteHundredThousandWhysDialogueRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CHILDREN</para>
        /// </summary>
        [NameInMap("ageGroup")]
        [Validation(Required=false)]
        public string AgeGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2f28670c-eba6-4afb-9610-0942c434a021</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700d4d9411efbe6e0</para>
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:1A:2B:3C:4D:5E</para>
        /// </summary>
        [NameInMap("macAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<ExecuteHundredThousandWhysDialogueRequestMessages> Messages { get; set; }
        public class ExecuteHundredThousandWhysDialogueRequestMessages : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

    }

}
