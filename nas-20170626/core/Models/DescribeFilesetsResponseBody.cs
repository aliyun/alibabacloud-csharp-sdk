// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The fileset information.</para>
        /// </summary>
        [NameInMap("Entries")]
        [Validation(Required=false)]
        public DescribeFilesetsResponseBodyEntries Entries { get; set; }
        public class DescribeFilesetsResponseBodyEntries : TeaModel {
            [NameInMap("Entrie")]
            [Validation(Required=false)]
            public List<DescribeFilesetsResponseBodyEntriesEntrie> Entrie { get; set; }
            public class DescribeFilesetsResponseBodyEntriesEntrie : TeaModel {
                /// <summary>
                /// <para>The time when the fileset was created.</para>
                /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-30T10:08:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable deletion protection to allow you to release the fileset by using the console or by calling the <a href="https://help.aliyun.com/document_detail/2402263.html">DeleteFileset</a> operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter can protect filesets only against manual releases, but not against automatic releases.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// <para>The fileset description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FileCountUsage")]
                [Validation(Required=false)]
                public long? FileCountUsage { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The fileset path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pathtoroot/fset</para>
                /// </summary>
                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                /// <summary>
                /// <para>The fileset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fset-1902718ea0ae****</para>
                /// </summary>
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

                /// <summary>
                /// <para>The fileset status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATING: The fileset is being created.</description></item>
                /// <item><description>CREATED: The fileset has been created and is running properly.</description></item>
                /// <item><description>RELEASING: The fileset is being released.</description></item>
                /// <item><description>RELEASED: The fileset has been deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CREATED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the fileset was last updated.</para>
                /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-30T10:08:08Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
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
