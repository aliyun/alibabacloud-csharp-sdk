// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class RebootRenderingServerRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RenderingInstanceIds")]
        [Validation(Required=false)]
        public List<string> RenderingInstanceIds { get; set; }

    }

}
