// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeStoragePackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of storage plans.</para>
        /// </summary>
        [NameInMap("Packages")]
        [Validation(Required=false)]
        public DescribeStoragePackagesResponseBodyPackages Packages { get; set; }
        public class DescribeStoragePackagesResponseBodyPackages : TeaModel {
            [NameInMap("Package")]
            [Validation(Required=false)]
            public List<DescribeStoragePackagesResponseBodyPackagesPackage> Package { get; set; }
            public class DescribeStoragePackagesResponseBodyPackagesPackage : TeaModel {
                /// <summary>
                /// <para>The end time of the validity period for the storage plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-05T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The ID of the file system that is bound to the storage plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>109c****66</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The ID of the storage plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>naspackage-@string(\&quot;*****\&quot;, *)-@string(\&quot;*****\&quot;, *)</para>
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

                /// <summary>
                /// <para>The capacity of the storage plan.</para>
                /// <para>Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The start time of the validity period for the storage plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-05T01:40:56Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the storage plan.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>free: The storage plan is not bound to a file system. You can bind the storage plan to a file system of the same storage type.</description></item>
                /// <item><description>bound: The storage plan is bound to a file system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>free</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the storage plan.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Performance</description></item>
                /// <item><description>Capacity</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Capacity</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of storage plans returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>035B3A3A-E514-4B41-B906-5D906CFB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of storage plans.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
