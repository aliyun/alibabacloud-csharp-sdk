// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetCasterConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The production studio ID. This ID can be used as a request parameter for querying the production studio stream address, starting the production studio, adding video resources, adding layouts, querying the layout list, adding components, and adding a program list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4810848-bcf9-4aef-bd4a-e6bba2d9****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
