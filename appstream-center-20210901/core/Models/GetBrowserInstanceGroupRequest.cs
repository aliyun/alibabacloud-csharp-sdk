// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetBrowserInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The cloud browser group ID. This parameter is required. Specify the ID of a browser group that is created under the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-0c7loey7fzjq****</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupId { get; set; }

    }

}
