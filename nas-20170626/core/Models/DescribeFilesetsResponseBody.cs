// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesetsResponseBody : TeaModel {
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public DescribeFilesetsResponseBodyEntries Entries { get; set; }
        public class DescribeFilesetsResponseBodyEntries : TeaModel {
            [NameInMap("Entrie")]
            [Validation(Required=false)]
            public List<DescribeFilesetsResponseBodyEntriesEntrie> Entrie { get; set; }
            public class DescribeFilesetsResponseBodyEntriesEntrie : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FileCountUsage")]
                [Validation(Required=false)]
                public long? FileCountUsage { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                [NameInMap("FsetId")]
                [Validation(Required=false)]
                public string FsetId { get; set; }

                [NameInMap("Quota")]
                [Validation(Required=false)]
                public DescribeFilesetsResponseBodyEntriesEntrieQuota Quota { get; set; }
                public class DescribeFilesetsResponseBodyEntriesEntrieQuota : TeaModel {
                    [NameInMap("FileCountLimit")]
                    [Validation(Required=false)]
                    public long? FileCountLimit { get; set; }

                    [NameInMap("SizeLimit")]
                    [Validation(Required=false)]
                    public long? SizeLimit { get; set; }

                }

                [NameInMap("SpaceUsage")]
                [Validation(Required=false)]
                public long? SpaceUsage { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-099394bd928c\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS for LINGJUN file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        [Obsolete]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
