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
        /// <item><description>Sample ID of a General-purpose NAS file system: 31a8e4\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of Extreme NAS file systems must start with extreme-, for example, extreme-0015\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS file systems must start with cpfs-. Example: cpfs-125487\<em>\</em>\<em>\</em>.</description></item>
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
        /// <item><description>all (default): All types.</description></item>
        /// <item><description>standard: General-purpose NAS file system.</description></item>
        /// <item><description>extreme: Extreme NAS file system.</description></item>
        /// <item><description>cpfs: CPFS file system.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Separate multiple data types with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>You can log on to the <a href="https://resourcemanager.console.aliyun.com/resource-groups?">Resource Management console</a> to view resource group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwavnfdf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The details about the tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeFileSystemsRequestTag> Tag { get; set; }
        public class DescribeFileSystemsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length.</description></item>
            /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
            /// <item><description>The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>test-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// <para>If you want to mount the file system on an Elastic Compute Service (ECS) instance, the file system and the ECS instance must reside in the same VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1sevsgtqvk5gxbl****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
