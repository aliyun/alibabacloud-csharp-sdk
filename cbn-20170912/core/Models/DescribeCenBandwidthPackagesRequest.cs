// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestFilter> Filter { get; set; }
        public class DescribeCenBandwidthPackagesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition.
            /// You can use filter conditions to filter the bandwidth plan instances to be viewed. The system supports the following filter conditions:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CenId</b>: The ID of the Cloud Enterprise Network (CEN) instance.</para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: The status of the bandwidth plan instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Idle</b>: Unbound.</description></item>
            /// <item><description><b>InUse</b>: Bound.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>CenBandwidthPackageId</b>: The ID of the bandwidth plan.</para>
            /// </description></item>
            /// <item><description><para><b>Name</b>: The name of the bandwidth plan.
            /// You can specify one or more filter conditions. The maximum value of <b>N</b> is <b>5</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CenId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value specified based on <b>Key</b>. You can specify multiple filter values for a single <b>Key</b>. The filter values have an <b>OR</b> relationship. A match occurs when any of the filter values is met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Idle</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to include renewal data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Includes renewal data.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not include renewal data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The logical relationship between filter conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): The filter conditions have an <b>AND</b> relationship. A match occurs only when all filter conditions are met.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The filter conditions have an <b>OR</b> relationship. A match occurs when any of the filter conditions is met.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOrKey")]
        [Validation(Required=false)]
        public bool? IsOrKey { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfnwjeo4tv****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The list of tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestTag> Tag { get; set; }
        public class DescribeCenBandwidthPackagesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>This parameter cannot be an empty string once specified. It can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>The tag value can be empty or a string of up to 128 characters. It cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to a tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
