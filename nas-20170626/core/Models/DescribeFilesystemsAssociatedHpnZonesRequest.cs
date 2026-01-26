// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesystemsAssociatedHpnZonesRequest : TeaModel {
        [NameInMap("Filesystems")]
        [Validation(Required=false)]
        public List<DescribeFilesystemsAssociatedHpnZonesRequestFilesystems> Filesystems { get; set; }
        public class DescribeFilesystemsAssociatedHpnZonesRequestFilesystems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>bmcpfs-290t15yn4uo8lid****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
