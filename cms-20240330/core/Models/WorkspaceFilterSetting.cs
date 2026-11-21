// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class WorkspaceFilterSetting : TeaModel {
        /// <summary>
        /// <para>The tag filter. This feature is not yet supported, and passing this parameter has no effect.</para>
        /// </summary>
        [NameInMap("tagSelector")]
        [Validation(Required=false)]
        public FilterSetting TagSelector { get; set; }

        /// <summary>
        /// <para>The list of workspace UUIDs.</para>
        /// </summary>
        [NameInMap("workspaceUuids")]
        [Validation(Required=false)]
        public List<string> WorkspaceUuids { get; set; }

    }

}
