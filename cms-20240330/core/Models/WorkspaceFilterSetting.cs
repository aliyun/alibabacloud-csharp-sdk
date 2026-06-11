// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class WorkspaceFilterSetting : TeaModel {
        /// <summary>
        /// <para>The tag filter.</para>
        /// </summary>
        [NameInMap("tagSelector")]
        [Validation(Required=false)]
        public FilterSetting TagSelector { get; set; }

        /// <summary>
        /// <para>A list of workspace UUIDs.</para>
        /// </summary>
        [NameInMap("workspaceUuids")]
        [Validation(Required=false)]
        public List<string> WorkspaceUuids { get; set; }

    }

}
