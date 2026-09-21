// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetWorkspaceAgenticFsMountRamAuthorizeUrlRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the target NAS AccessPoint. This parameter corresponds to the server and fileSystemId parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-0123456789abcdef0</para>
        /// </summary>
        [NameInMap("accessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>The ID of the NAS file system to which the target AccessPoint belongs. This parameter corresponds to the server and accessPointId parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789</para>
        /// </summary>
        [NameInMap("fileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The domain name of the target AccessPoint, obtained from the DomainName field of the NAS ListAccessPoints operation. Do not include the protocol, port, or path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("server")]
        [Validation(Required=false)]
        public string Server { get; set; }

    }

}
