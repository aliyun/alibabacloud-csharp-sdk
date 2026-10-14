// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetC2paSignResultRequest : TeaModel {
        /// <summary>
        /// <para>The opaque task ID returned by CreateC2paSignTask, up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7093c29e-f472-4e1e-91c6-a43df7c7382e</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
