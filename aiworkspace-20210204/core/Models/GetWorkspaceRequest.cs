// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return additional information, such as the workspace owner. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Does not return additional information.</para>
        /// </description></item>
        /// <item><description><para>true: Returns additional information.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
