// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetWebTerminalRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to create a shared link for accessing the container. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns a shared link for accessing the container. The link expires after 30 seconds and can be used only once. After someone accesses the container through this link, subsequent requests using the same link are invalid.</description></item>
        /// <item><description>false: Returns a regular link for accessing the container. Alibaba Cloud identity authentication is required when using this link. The link expires after 30 seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>Pod UID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>94a7cc7c-0033-48b5-85bd-71c63592****</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

    }

}
