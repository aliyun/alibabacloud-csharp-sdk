// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemsRequest : TeaModel {
        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description>General-purpose NAS: 31a8e4****.</description></item>
        /// <item><description>Extreme NAS: must start with extreme-, such as extreme-0015****.</description></item>
        /// <item><description>CPFS (locally redundant): must start with cpfs-, such as cpfs-125487****.</description></item>
        /// <item><description>CPFS SE (zone-redundant): must start with cpfsse-, such as cpfsse-022c71b134****.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all (default): queries all types.</description></item>
        /// <item><description>standard: General-purpose NAS.</description></item>
        /// <item><description>extreme: Extreme NAS.</description></item>
        /// <item><description>cpfs: Cloud Parallel File Storage (locally redundant).</description></item>
        /// <item><description>cpfsse: Cloud Parallel File Storage SE (zone-redundant).</description></item>
        /// </list>
        /// <remarks>
        /// <para>To query multiple types, separate them with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The page number of the file system list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of file systems on each page during a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>You can view the resource group ID in the <a href="https://resourcemanager.console.aliyun.com/resource-groups?">Resource Management console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwavnfef****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>General-purpose NAS: Capacity, Performance, and Premium.</description></item>
        /// <item><description>Extreme NAS: standard and advance.</description></item>
        /// <item><description>CPFS: advance_100 (100 MB/s/TiB baseline), advance_200 (200 MB/s/TiB baseline), and economic.</description></item>
        /// <item><description>CPFS SE: advance_100 (100 MB/s/TiB baseline).</description></item>
        /// <item><description>AgenticFS: Agentic (available only when FileSystemType is set to standard).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Capacity</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The collection of tag information.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeFileSystemsRequestTag> Tag { get; set; }
        public class DescribeFileSystemsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length.</description></item>
            /// <item><description>The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
            /// <item><description>The tag value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1sevsgtqvk5gxbl****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
