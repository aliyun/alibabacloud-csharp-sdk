// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description><para>For General-purpose NAS file systems, the ID is a string of characters, such as <c>31a8e4****</c>.</para>
        /// </description></item>
        /// <item><description><para>For Extreme NAS file systems, the ID must start with <c>extreme-</c>, such as <c>extreme-0015****</c>.</para>
        /// </description></item>
        /// <item><description><para>For Cloud Parallel File System (CPFS) file systems, the ID must start with <c>cpfs-</c>, such as <c>cpfs-125487****</c>.</para>
        /// </description></item>
        /// <item><description><para>For Cloud Parallel File System SE (CPFS SE) file systems, the ID must start with <c>cpfsse-</c>, such as <c>cpfsse-022c71b134****</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The file system type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>all</c> (default): all file system types.</para>
        /// </description></item>
        /// <item><description><para><c>standard</c>: General-purpose NAS.</para>
        /// </description></item>
        /// <item><description><para><c>extreme</c>: Extreme NAS.</para>
        /// </description></item>
        /// <item><description><para><c>cpfs</c>: Cloud Parallel File System (CPFS).</para>
        /// </description></item>
        /// <item><description><para><c>cpfsse</c>: Cloud Parallel File System SE (CPFS SE).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Separate multiple types with commas.</para>
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
        /// <para>The page number starts at 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of file systems to return on each page.</para>
        /// <para>Value range: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <para>You can view this ID in the <a href="https://resourcemanager.console.aliyun.com/resource-groups?">Resource Management console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwavnfef****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags used to filter file systems. You can specify 1 to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeFileSystemsRequestTag> Tag { get; set; }
        public class DescribeFileSystemsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description><para>The tag key can be up to 128 characters long.</para>
            /// </description></item>
            /// <item><description><para>It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// </description></item>
            /// <item><description><para>It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// </list>
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
            /// <item><description></description></item>
            /// <item><description><para>The tag value can be up to 128 characters long.</para>
            /// </description></item>
            /// <item><description><para>It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// </description></item>
            /// <item><description><para>It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
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
        /// <para>The ID of the VPC.</para>
        /// <para>The file system and the ECS instance used for mounting must be in the same VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1sevsgtqvk5gxbl****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
