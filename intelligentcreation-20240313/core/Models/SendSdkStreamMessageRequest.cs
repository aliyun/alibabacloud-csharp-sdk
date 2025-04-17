// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SendSdkStreamMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>header</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("header")]
        [Validation(Required=false)]
        public string Header { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>avatar</para>
        /// </summary>
        [NameInMap("moduleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GetProject</para>
        /// </summary>
        [NameInMap("operationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
