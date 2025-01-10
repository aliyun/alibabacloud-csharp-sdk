// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVpdsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePage")]
        [Validation(Required=false)]
        public bool? EnablePage { get; set; }

        /// <summary>
        /// <para>Queries the network segments of Lingjun that are not bound to a specified Lingjun HUB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
        /// </summary>
        [NameInMap("FilterErId")]
        [Validation(Required=false)]
        public string FilterErId { get; set; }

        /// <summary>
        /// <para>If you select a drop-down list, only the basic information (including the instance ID and instance name) is returned. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Select Query Use from the drop-down list.</description></item>
        /// <item><description><b>false</b>: Normal queries are used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForSelect")]
        [Validation(Required=false)]
        public bool? ForSelect { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Start value: 1 Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
        /// <item><description><b>Available</b>: Normal.</description></item>
        /// <item><description><b>Not Available</b>: Not available.</description></item>
        /// <item><description><b>Executing</b>: The task is being executed.</description></item>
        /// <item><description><b>Deleting</b>: The account is being deleted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListVpdsRequestTag> Tag { get; set; }
        public class ListVpdsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the VPN attachment.</para>
            /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-vpd-region</para>
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
            /// <para>wulanchabu</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPD instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-fuliephf</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The name of the VPD instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-1</para>
        /// </summary>
        [NameInMap("VpdName")]
        [Validation(Required=false)]
        public string VpdName { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the dependent resource information. We recommend that you do not query the dependent resource information when you query by page. You can query the dependent resource information separately when you delete it. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: with dependency information.</description></item>
        /// <item><description><b>false</b>: does not include dependency information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithDependence")]
        [Validation(Required=false)]
        public bool? WithDependence { get; set; }

        /// <summary>
        /// <para>Queries the information about a Lingjun CIDR block that is not bound to a Lingjun connection. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: filters out VPDs that have been bound to VCC</description></item>
        /// <item><description><b>false</b>: does not filter VPD that has been bound to VCC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithoutVcc")]
        [Validation(Required=false)]
        public bool? WithoutVcc { get; set; }

    }

}
