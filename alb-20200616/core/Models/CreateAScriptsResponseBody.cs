// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateAScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of programmable script IDs.</para>
        /// </summary>
        [NameInMap("AScriptIds")]
        [Validation(Required=false)]
        public List<CreateAScriptsResponseBodyAScriptIds> AScriptIds { get; set; }
        public class CreateAScriptsResponseBodyAScriptIds : TeaModel {
            /// <summary>
            /// <para>The ID of the programmable script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>as-xvq5igaa7uv6vr****</para>
            /// </summary>
            [NameInMap("AScriptId")]
            [Validation(Required=false)]
            public string AScriptId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c607642-535e-4e06-9d77-df53049b****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF0FE763-9603-558F-A55B-0F4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
