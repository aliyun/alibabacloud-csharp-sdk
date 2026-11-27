// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class ModifyAppStreamingOutTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. You can create and query it in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wv7N****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Template.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamingOutTemplate")]
        [Validation(Required=false)]
        public string StreamingOutTemplateShrink { get; set; }

    }

}
