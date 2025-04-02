// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetWebTerminalRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to create a shareable link to access the container. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns a shareable link to access the container. The link will expire after 30 seconds and can only be used once. After you access the container by using the link, other requests that use this link to access the container become invalid.</description></item>
        /// <item><description>false: returns a common shareable link to access the container. If you use a common shareable link to access a container, Alibaba Cloud identity authentication is required. The link will expire after 30 seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The pod UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94a7cc7c-0033-48b5-85bd-71c63592c268</para>
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

    }

}
