// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetFilesetResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFilesetResponseBodyData Data { get; set; }
        public class GetFilesetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the fileset was created.</para>
            /// <para>Return format: <c>yyyy-MM-dd HH:mm:ss</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-21 12:49:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the fileset is protected from being released through the console or the <a href="https://help.aliyun.com/document_detail/2402263.html">DeleteFileset</a> operation.</para>
            /// <list type="bullet">
            /// <item><description>true: Enables release protection. The fileset cannot be released.</description></item>
            /// <item><description>false (default): Disables release protection. The fileset can be released.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter can protect filesets only against manual releases, but not against automatic releases.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The description of the fileset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The usage of the file quantity.</para>
            /// <remarks>
            /// <para> Only CPFS for LINGJUN V2.7.0 and later support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("FileCountUsage")]
            [Validation(Required=false)]
            public long? FileCountUsage { get; set; }

            /// <summary>
            /// <para>The ID of the file system.</para>
            /// <list type="bullet">
            /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-125487\<em>\</em>\<em>\</em>.</description></item>
            /// <item><description>The IDs of CPFS for Lingjun file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-0015\<em>\</em>\<em>\</em>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cpfs-0244729a8ef8****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The directory of the fileset in the CPFS file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pathtoroot/fset/</para>
            /// </summary>
            [NameInMap("FileSystemPath")]
            [Validation(Required=false)]
            public string FileSystemPath { get; set; }

            /// <summary>
            /// <para>The fileset ID.</para>
            /// <remarks>
            /// <para> This parameter is required for CPFS file systems.</para>
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
            /// <para> Only CPFS for Lingjun V2.7.0 and later support this parameter.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public GetFilesetResponseBodyDataQuota Quota { get; set; }
            public class GetFilesetResponseBodyDataQuota : TeaModel {
                /// <summary>
                /// <para>The file quantity quota. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Minimum value: 10,000.</description></item>
                /// <item><description>Maximum value: 10,000,000,000.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                /// <summary>
                /// <para>The total quota capacity limit. Unit: bytes.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Minimum value: 10,737,418,240 (10 GiB).</description></item>
                /// <item><description>Step size: 1,073,741,824 (1 GiB).</description></item>
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
            /// <para> Only CPFS for Lingjun V2.7.0 and later support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
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
            /// <para>Return format: <c>yyyy-MM-dd HH:mm:ss</c></para>
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
