// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetWebTerminalRequest : TeaModel {
        /// <summary>
        /// <para>The name of the container. If this parameter is not specified, the WebTerminal of the primary container is accessed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sidecar-test</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a shareable link for accessing the container. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns a shareable link for accessing the container. The link expires after 30 seconds and can be used only once. After the container is accessed through this link, subsequent requests to access the container by using the same link become invalid.</description></item>
        /// <item><description>false: Returns a regular link for accessing the container. Alibaba Cloud identity verification is required when you use the link. The link expires after 30 seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The Pod UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94a7cc7c-0033-48b5-85bd-71c63592****</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

    }

}
