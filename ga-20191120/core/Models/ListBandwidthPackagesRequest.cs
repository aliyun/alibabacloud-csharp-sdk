// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBandwidthPackagesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp1sgzldyj6b4q7cx****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the GA instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2ry6mp2c****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: The bandwidth plan is being initialized.</description></item>
        /// <item><description><b>active</b>: The bandwidth plan is available.</description></item>
        /// <item><description><b>binded</b>: The bandwidth plan is associated.</description></item>
        /// <item><description><b>binding</b>: The bandwidth plan is being associated.</description></item>
        /// <item><description><b>unbinding</b>: The bandwidth plan is being disassociated.</description></item>
        /// <item><description><b>updating</b>: The bandwidth plan is being updated.</description></item>
        /// <item><description><b>finacialLocked</b>: The bandwidth plan is locked due to overdue payments.</description></item>
        /// <item><description><b>locked</b>: The bandwidth plan is locked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The tag of the bandwidth plan.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListBandwidthPackagesRequestTag> Tag { get; set; }
        public class ListBandwidthPackagesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the bandwidth plan. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the bandwidth plan. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: a basic bandwidth plan</description></item>
        /// <item><description><b>CrossDomain</b>: a cross-border acceleration bandwidth plan</description></item>
        /// </list>
        /// <para>If you call this operation on the China site (aliyun.com), you can set Type only to <b>Basic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
