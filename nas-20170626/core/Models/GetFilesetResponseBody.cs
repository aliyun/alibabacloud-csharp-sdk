// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetFilesetResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFilesetResponseBodyData Data { get; set; }
        public class GetFilesetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the Fileset was created.</para>
            /// <para>Format: <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-21 12:49:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The release protection property of the instance. Specifies whether the instance can be released from the console or by calling the <a href="https://help.aliyun.com/document_detail/2402263.html">DeleteFileset</a> operation.</para>
            /// <list type="bullet">
            /// <item><description>true: Release protection is enabled.</description></item>
            /// <item><description>false (default): Release protection is disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This property applies only to manual release operations and does not apply to system-initiated release operations.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The description of the Fileset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The file count usage.</para>
            /// <remarks>
            /// <para>Only CPFS for Lingjun 2.7.0 and later support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("FileCountUsage")]
            [Validation(Required=false)]
            public long? FileCountUsage { get; set; }

            /// <summary>
            /// <para>The file system ID.</para>
            /// <list type="bullet">
            /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-125487\<em>\</em>\<em>\</em>.</para>
            /// </description></item>
            /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-0015\<em>\</em>\<em>\</em>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cpfs-0244729a8ef8****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The path of the Fileset in the CPFS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pathtoroot/fset/</para>
            /// </summary>
            [NameInMap("FileSystemPath")]
            [Validation(Required=false)]
            public string FileSystemPath { get; set; }

            /// <summary>
            /// <para>The Fileset ID.</para>
            /// <remarks>
            /// <para>This parameter is required if the file system type is CPFS.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fset-03250e8fe78d****</para>
            /// </summary>
            [NameInMap("FsetId")]
            [Validation(Required=false)]
            public string FsetId { get; set; }

            /// <summary>
            /// <para>The quota information.</para>
            /// <remarks>
            /// <para>Only CPFS for Lingjun 2.7.0 and later support this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public GetFilesetResponseBodyDataQuota Quota { get; set; }
            public class GetFilesetResponseBodyDataQuota : TeaModel {
                /// <summary>
                /// <para>The file count limit of the quota. Value range:</para>
                /// <list type="bullet">
                /// <item><description><para>Minimum value: 10,000.</para>
                /// </description></item>
                /// <item><description><para>Maximum value: 10,000,000,000.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                /// <summary>
                /// <para>The total capacity limit of the quota. Unit: bytes.</para>
                /// <para>Value range:</para>
                /// <list type="bullet">
                /// <item><description><para>Minimum value: 10,737,418,240 (10 GiB).</para>
                /// </description></item>
                /// <item><description><para>Increment: 1,073,741,824 (1 GiB).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10,737,418,240</para>
                /// </summary>
                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public long? SizeLimit { get; set; }

            }

            /// <summary>
            /// <para>The capacity usage. Unit: bytes.</para>
            /// <remarks>
            /// <para>Only CPFS for Lingjun 2.7.0 and later support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("SpaceUsage")]
            [Validation(Required=false)]
            public long? SpaceUsage { get; set; }

            /// <summary>
            /// <para>The status of the Fileset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: The Fileset is being created.</description></item>
            /// <item><description>CREATED: The Fileset is created and running as expected. </description></item>
            /// <item><description>RELEASING: The Fileset is being released.</description></item>
            /// <item><description>RELEASED: The Fileset is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the Fileset was last updated.</para>
            /// <para>Format: <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-22 12:49:25</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
