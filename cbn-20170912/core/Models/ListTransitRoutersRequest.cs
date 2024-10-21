// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRoutersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-j3jzhw1zpau2km****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The field that is used to enable or disable a feature of the transit router.</para>
        /// </summary>
        [NameInMap("FeatureFilter")]
        [Validation(Required=false)]
        public List<ListTransitRoutersRequestFeatureFilter> FeatureFilter { get; set; }
        public class ListTransitRoutersRequestFeatureFilter : TeaModel {
            /// <summary>
            /// <para>The value of the field that is used to enable or disable a feature of the transit router. Supported fields:</para>
            /// <list type="bullet">
            /// <item><description><b>Multicast</b>: the multicast feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Multicast</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The fields that are used to enable or disable the features of the transit router. The <b>Multicast</b> field supports only one value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: enables multicast.</description></item>
            /// <item><description><b>Disabled</b>: disables multicast.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

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
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the transit router is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The status of the transit router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: The transit router is being created.</description></item>
        /// <item><description><b>Active</b>: The transit router is available.</description></item>
        /// <item><description><b>Modifying</b>: The transit router is being modified</description></item>
        /// <item><description><b>Deleting</b>: The transit router is being deleted.</description></item>
        /// <item><description><b>Upgrading</b>: The transit router is being upgraded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The information about the tags.</para>
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTransitRoutersRequestTag> Tag { get; set; }
        public class ListTransitRoutersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be 0 to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-uf654ttymmljlvh2x****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The name of the Enterprise Edition transit router.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterName")]
        [Validation(Required=false)]
        public string TransitRouterName { get; set; }

        /// <summary>
        /// <para>The edition of the transit router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enterprise</b>: Enhance Edition</description></item>
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
