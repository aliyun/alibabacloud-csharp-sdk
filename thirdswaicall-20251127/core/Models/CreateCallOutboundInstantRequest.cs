// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ThirdswAicall20251127.Models
{
    public class CreateCallOutboundInstantRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EncryptCall")]
        [Validation(Required=false)]
        public bool? EncryptCall { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;start&quot;:&quot;2220&quot;}</para>
        /// </summary>
        [NameInMap("PromptVariables")]
        [Validation(Required=false)]
        public string PromptVariables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
