// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteTranscodeTemplateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of transcoding templates that do not exist when you delete transcoding templates by specifying template IDs.</para>
        /// </summary>
        [NameInMap("NonExistTranscodeTemplateIds")]
        [Validation(Required=false)]
        public List<string> NonExistTranscodeTemplateIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
