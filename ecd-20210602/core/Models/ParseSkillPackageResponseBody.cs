// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class ParseSkillPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05C2791F-41A7-5E7C-B5E4-1401FD0E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The key of the skill package parsing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E7D8B71-2677-1B4C-9E25-A88B9******</para>
        /// </summary>
        [NameInMap("TaskKey")]
        [Validation(Required=false)]
        public string TaskKey { get; set; }

    }

}
