// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetImageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to display optional information. Optional information currently includes Labels.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Optional information is not displayed.</description></item>
        /// <item><description>true: Optional information is displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
