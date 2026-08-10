// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteLiveTranscodeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template ID. You can obtain the ID from the <a href="https://ice.console.aliyun.com/summary">Intelligent Media Services console</a> &gt; Template Management &gt; Real-time Transcoding Template, or from the response parameters of <a href="https://help.aliyun.com/document_detail/449217.html">CreateLiveTranscodeTemplate</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>d80e4e4044975745c14b</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
