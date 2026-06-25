// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetImageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to display non-essential information. Non-essential information currently includes labels.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Does not display non-essential information.</para>
        /// </description></item>
        /// <item><description><para>true: Displays non-essential information.</para>
        /// </description></item>
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
