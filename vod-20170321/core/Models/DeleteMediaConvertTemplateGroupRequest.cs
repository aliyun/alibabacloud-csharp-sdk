// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMediaConvertTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceDelGroup")]
        [Validation(Required=false)]
        public string ForceDelGroup { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c71a339fe52b4fa6f4527****</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e0d1a64b2e5f3c8a9b0c1d2e3f4051****,4c71a339fe52b4fa6f4527****</para>
        /// </summary>
        [NameInMap("TranscodeTemplateIdList")]
        [Validation(Required=false)]
        public string TranscodeTemplateIdList { get; set; }

    }

}
