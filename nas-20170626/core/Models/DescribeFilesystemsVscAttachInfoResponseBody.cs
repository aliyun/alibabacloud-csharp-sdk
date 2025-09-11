// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesystemsVscAttachInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of directories to return for each query.</para>
        /// <para>Valid values: 10 to 1000.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Query token, which is the NextToken value returned from the previous API call.</para>
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
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of associated information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A collection of file system and virtual channel association data.</para>
        /// </summary>
        [NameInMap("VscAttachInfo")]
        [Validation(Required=false)]
        public DescribeFilesystemsVscAttachInfoResponseBodyVscAttachInfo VscAttachInfo { get; set; }
        public class DescribeFilesystemsVscAttachInfoResponseBodyVscAttachInfo : TeaModel {
            [NameInMap("VscAttachInfo")]
            [Validation(Required=false)]
            public List<DescribeFilesystemsVscAttachInfoResponseBodyVscAttachInfoVscAttachInfo> VscAttachInfo { get; set; }
            public class DescribeFilesystemsVscAttachInfoResponseBodyVscAttachInfoVscAttachInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bmcpfs-290t15yn4uo8lid****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The association status of the file system and virtual channel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Attaching: The association is being made.</description></item>
                /// <item><description>Attached: The association is complete.</description></item>
                /// <item><description>Detaching: The association is being canceled.</description></item>
                /// <item><description>Detached: The association is canceled.</description></item>
                /// <item><description>Failed: The association failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Attached</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the virtual storage channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsc-8vb864o3ppwfvh****</para>
                /// </summary>
                [NameInMap("VscId")]
                [Validation(Required=false)]
                public string VscId { get; set; }

            }

        }

    }

}
