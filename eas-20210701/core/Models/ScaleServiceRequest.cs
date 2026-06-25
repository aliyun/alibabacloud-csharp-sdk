// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ScaleServiceRequest : TeaModel {
        /// <summary>
        /// <para>The target number of instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public long? Instance { get; set; }

        /// <summary>
        /// <para>A list of instance names to prioritize for removal during a scale-in operation.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("InstancesToDelete")]
        [Validation(Required=false)]
        public List<string> InstancesToDelete { get; set; }

    }

}
