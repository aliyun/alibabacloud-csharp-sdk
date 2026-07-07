// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class GetParseProgressRequest : TeaModel {
        /// <summary>
        /// <para>The task key for parsing the skill package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E7D8B71-2677-1B4C-9E25-A88B9C5******</para>
        /// </summary>
        [NameInMap("TaskKey")]
        [Validation(Required=false)]
        public string TaskKey { get; set; }

    }

}
