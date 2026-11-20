// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ScaleServiceRequest : TeaModel {
        /// <summary>
        /// <para>The target instance count for scaling.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public long? Instance { get; set; }

        /// <summary>
        /// <para>The list of instance names to prioritize for deletion during a scale-in operation. Note: This parameter takes effect only during scale-in.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("InstancesToDelete")]
        [Validation(Required=false)]
        public List<string> InstancesToDelete { get; set; }

    }

}
