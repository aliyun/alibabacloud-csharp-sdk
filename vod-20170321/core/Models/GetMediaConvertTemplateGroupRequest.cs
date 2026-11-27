// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaConvertTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the transcoding template group. Only MC transcoding template groups created by calling AddMediaConvertTemplateGroup can be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c71a339fe52b4fa6f4527****</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

    }

}
