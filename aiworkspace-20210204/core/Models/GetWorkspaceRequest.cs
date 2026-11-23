// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>A comma-separated string used to specify additional information to return. This field does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotSupport</para>
        /// </summary>
        [NameInMap("ExtraVerboseFields")]
        [Validation(Required=false)]
        public string ExtraVerboseFields { get; set; }

        /// <summary>
        /// <para>Specifies whether to display supplementary information such as the workspace owner. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Does not display supplementary information.</description></item>
        /// <item><description>true: Displays supplementary information.
        /// Default value: false.</description></item>
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
