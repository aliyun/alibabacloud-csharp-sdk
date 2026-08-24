// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class AuthorizeFileUploadRequest : TeaModel {
        /// <summary>
        /// <para>The Agent or client source that initiates the call, such as codex, cursor, or openapi. Maximum length: 32 characters. Used only for statistics and does not participate in authentication, throttling, quota, or billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>codex</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The format of the file to be uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// <para>The region ID, such as cn-beijing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
