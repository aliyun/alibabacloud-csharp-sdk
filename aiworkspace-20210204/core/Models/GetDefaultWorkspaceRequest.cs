// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDefaultWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return detailed information about the default workspace. The detailed information includes the Conditions list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Detailed information is not returned.</para>
        /// </description></item>
        /// <item><description><para>true: Detailed information is returned.</para>
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
