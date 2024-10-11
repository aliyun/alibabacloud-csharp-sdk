// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetDefaultTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the transcoding template group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d58079958be8d*****b699ab7ab6e1bf</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

    }

}
