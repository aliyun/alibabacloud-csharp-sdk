// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesRequest : TeaModel {
        /// <summary>
        /// <para>The filter configurations.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestFilter> Filter { get; set; }
        public class DescribeCenBandwidthPackagesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter conditions. You can use filter conditions to filter the bandwidth plans that you want to query. The following filter conditions are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CenId</b>: CEN instance ID</para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: bandwidth plan status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Idle</b>: not associated with a CEN instance.</description></item>
            /// <item><description><b>InUse</b>: associated with a CEN instance.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>CenBandwidthPackageId</b>: bandwidth plan ID</para>
            /// </description></item>
            /// <item><description><para><b>Name</b>: bandwidth plan name You can specify one or more filter conditions. The maximum value of <b>N</b> is <b>5</b>.</para>
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
            /// <para>Specify a filter value based on the <b>Key</b> parameter. You can specify multiple filter values for each <b>Key</b>. The logical operator between filter values is <b>OR</b>. If one filter value is matched, the filter condition is matched.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The logical operator between the filter conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): <b>AND</b> Bandwidth plans that meet all filter conditions are returned.</description></item>
        /// <item><description><b>true</b>: <b>OR</b> Bandwidth plans that meet one of the filter conditions are returned.</description></item>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
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
        /// <para>The information about the tags.</para>
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestTag> Tag { get; set; }
        public class DescribeCenBandwidthPackagesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag keys.</para>
            /// <para>The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag values.</para>
            /// <para>The tag values can be 0 to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>The tag value of each tag key must be unique. You can specify at most 20 tag values in each call.</para>
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
