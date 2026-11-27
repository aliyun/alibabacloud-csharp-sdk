// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class EnableDataInsightRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system. The ID must start with <c>bmcpfs-</c>, such as bmcpfs-125487****. You can obtain the ID by purchasing a file system through the NAS console or by calling the <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-describefilesystems">DescribeFileSystems</a> operation and setting FileSystemType to bmcpfs.</para>
        /// <remarks>
        /// <para>This feature is supported only by CPFS for Lingjun file systems.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64y*****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

    }

}
