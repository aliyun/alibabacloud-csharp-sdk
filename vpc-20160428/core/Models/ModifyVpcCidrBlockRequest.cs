// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpcCidrBlockRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client and ensure that the value is unique among different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b> identifier. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system sends a check request and does not modify the CIDR block of the virtual private cloud (VPC). If the check fails, the system returns the corresponding error. If the check succeeds, the system returns the error code <c>DryRunOperation</c>.</description></item>
        /// <item><description><b>false</b> (default): The system sends a normal request. After the request passes the check, the system returns an HTTP 2xx status code and directly performs the modification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The CIDR block of the VPC that you want to modify. Both primary and secondary CIDR blocks are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("OriginalCidrBlock")]
        [Validation(Required=false)]
        public string OriginalCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VPC is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The target CIDR block of the VPC after the modification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/16</para>
        /// </summary>
        [NameInMap("TargetCidrBlock")]
        [Validation(Required=false)]
        public string TargetCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the VPC that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1di7uewzmtvfuq8****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
