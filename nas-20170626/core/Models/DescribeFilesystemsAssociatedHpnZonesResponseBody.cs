// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesystemsAssociatedHpnZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of HpnZones associated with the file system.</para>
        /// </summary>
        [NameInMap("Filesystems")]
        [Validation(Required=false)]
        public List<DescribeFilesystemsAssociatedHpnZonesResponseBodyFilesystems> Filesystems { get; set; }
        public class DescribeFilesystemsAssociatedHpnZonesResponseBodyFilesystems : TeaModel {
            /// <summary>
            /// <para>The list of HpnZones supported by the file system.</para>
            /// </summary>
            [NameInMap("AssociatedHpnZones")]
            [Validation(Required=false)]
            public List<string> AssociatedHpnZones { get; set; }

            /// <summary>
            /// <para>The ID of the CPFS for Lingjun file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bmcpfs-290t15yn4uo8lid****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
