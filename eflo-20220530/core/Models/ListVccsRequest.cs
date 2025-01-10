// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVccsRequest : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of the Lingjun connection instance. Unit: Mbit/s. Valid values: 1000 to 400000</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the CEN instance; <a href="https://help.aliyun.com/document_detail/181681.html">What is the CEN?</a></para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/468215.htm">DescribeCens</a> to query the information of CEN instances under the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-95iwtpyvj3kk1v0ao0</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable paged query. Optional values:</para>
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
        /// <para>Excludes all data in the specified status. If the status parameter exists, ExStatus does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("ExStatus")]
        [Validation(Required=false)]
        public string ExStatus { get; set; }

        /// <summary>
        /// <para>Filter queries by Lingjun HUB instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-a7rqv1rq</para>
        /// </summary>
        [NameInMap("FilterErId")]
        [Validation(Required=false)]
        public string FilterErId { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
        /// <para>The instance status.</para>
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
        public List<ListVccsRequestTag> Tag { get; set; }
        public class ListVccsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the VPN attachment.</para>
            /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-vcc</para>
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
            /// <para>vcc-group-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Lingjun connection instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-zvp2w222001</para>
        /// </summary>
        [NameInMap("VccId")]
        [Validation(Required=false)]
        public string VccId { get; set; }

        /// <summary>
        /// <para>Virtual Private Cloud IDs; <a href="https://help.aliyun.com/document_detail/34217.html">What is Virtual Private Cloud</a></para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35739.html#demo-0">DescribeVpcs</a> operation to query the specified VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nrtkmamy329u6a1z0i</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Lingjun CIDR block instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-omqutbff</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

    }

}
