// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVpcHoneyPotListRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the VPCs to query have cloud honeypot enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled</description></item>
        /// <item><description><b>false</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HoneyPotExistence")]
        [Validation(Required=false)]
        public bool? HoneyPotExistence { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para>We recommend that you specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which the honeypot instance that you want to query resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to obtain the VPC ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-d7o009q63fqy21r8u****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The name of the VPC in which the honeypot instance that you want to query resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to obtain the VPC name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abcnet</para>
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC in which the honeypot instance that you want to query resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to obtain the region ID of the VPC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-2</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
