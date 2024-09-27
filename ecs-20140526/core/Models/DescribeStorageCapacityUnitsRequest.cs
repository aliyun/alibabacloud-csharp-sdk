// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageCapacityUnitsRequest : TeaModel {
        /// <summary>
        /// <para>The allocation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: queries SCUs that belong to the current Alibaba Cloud account.</description></item>
        /// <item><description>Shared: queries SCUs shared between the Alibaba Cloud account and RAM users.</description></item>
        /// </list>
        /// <para>Default value: Normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AllocationType")]
        [Validation(Required=false)]
        public string AllocationType { get; set; }

        /// <summary>
        /// <para>The capacity of the SCU. Unit: GiB. Valid values: 20, 40, 100, 200, 500, 1024, 2048, 5120, 10240, 20480, and 51200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// <para>The name of the SCU. The name must be 2 to 128 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testScuName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the SCU. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The state of SCUs. You can specify 1 to 4 types of state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The SCUs are being created.</description></item>
        /// <item><description>Active: The SCUs are in effect.</description></item>
        /// <item><description>Expired: The SCUs have expired.</description></item>
        /// <item><description>Pending: The SCUs have not taken effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>One or multiple SCU IDs. You can specify 1 to 100 SCU IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scu-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageCapacityUnitId")]
        [Validation(Required=false)]
        public List<string> StorageCapacityUnitId { get; set; }

        /// <summary>
        /// <para>The tags of the SCUs.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeStorageCapacityUnitsRequestTag> Tag { get; set; }
        public class DescribeStorageCapacityUnitsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the SCU. N is the identifier for the tag, which you can use to set and query the tag. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the SCU. N is the identifier for the tag, which you can use to set and query the tag. The value of N must coincide with <c>Tag.N.Key</c>. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
