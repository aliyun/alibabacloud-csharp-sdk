// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListSubnetsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query by page. Optional values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable pagination query</description></item>
        /// <item><description><b>false</b>: Pagination query is disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePage")]
        [Validation(Required=false)]
        public bool? EnablePage { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.htm?spm=a2c4g.11186623.0.0.29e15d7akXhpuu">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aeky5f3qx6ceapq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Available</b>: Normal</description></item>
        /// <item><description><b>Not Available</b>: Unavailable</description></item>
        /// <item><description><b>Executing</b>: Executing</description></item>
        /// <item><description><b>Deleting</b>: The node is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Lingjun subnet instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>subnet-anhtskts</para>
        /// </summary>
        [NameInMap("SubnetId")]
        [Validation(Required=false)]
        public string SubnetId { get; set; }

        /// <summary>
        /// <para>Lingjun subnet instance name</para>
        /// 
        /// <b>Example:</b>
        /// <para>subnet-1</para>
        /// </summary>
        [NameInMap("SubnetName")]
        [Validation(Required=false)]
        public string SubnetName { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListSubnetsRequestTag> Tag { get; set; }
        public class ListSubnetsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the VPN attachment.</para>
            /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-subnet</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the VPN connection.</para>
            /// <para>The tag value can be empty or a string of up to 128 characters. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// <para>Each key-value pair must be unique. You can specify values for at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subnet-group-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Lingjun Subnet Usage Type; optional; optional. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>If you do not set this field for a common type</b></description></item>
        /// <item><description><b>OOB</b> :OOB type</description></item>
        /// <item><description><b>LB</b>: LB type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the Lingjun CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-fuliephf</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The zone ID of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
