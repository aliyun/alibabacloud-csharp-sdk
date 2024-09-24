// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVpcHoneyPotListRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the cloud honeypot feature is enabled for the VPCs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HoneyPotExistence")]
        [Validation(Required=false)]
        public bool? HoneyPotExistence { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the VPC on which the honeypot is deployed.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to query the IDs of VPCs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-d7o009q63fqy21r8u****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The name of the VPC.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to query the names of VPCs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abcnet</para>
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeVpcList~~">DescribeVpcList</a> operation to query the region IDs of VPCs.</para>
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
