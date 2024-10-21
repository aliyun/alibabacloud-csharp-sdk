// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterCidrAllocationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network instance connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-2nalp6yksc805w****</para>
        /// </summary>
        [NameInMap("AttachmentId")]
        [Validation(Required=false)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// <para>The name of the network instance connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("AttachmentName")]
        [Validation(Required=false)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// <para>The CIDR block of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/24</para>
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        /// <summary>
        /// <para>The CIDR blocks that have IP addresses allocated to network instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/28</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The CIDR block that is for exclusive use.</para>
        /// <para>Set the value to <b>VPN</b>, which specifies the CIDR block that is reserved for VPN connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPN</para>
        /// </summary>
        [NameInMap("DedicatedOwnerId")]
        [Validation(Required=false)]
        public string DedicatedOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify a value for <b>MaxResults</b>, entries are returned in one response. After you send the request, the value of <b>MaxResults</b> includes all entries.</para>
        /// </description></item>
        /// <item><description><para>If you specify a value for <b>MaxResults</b>, entries are returned in batches. Valid values: <b>1</b> to <b>100</b>. We recommend that you set <b>MaxResults</b> to <b>20</b>.</para>
        /// <para>The value of <b>MaxResults</b> in the response indicates that number of entries in the current batch.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query or no subsequent query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a subsequent query is to be sent, set the value to the value of <b>NextToken</b> that is returned from the last call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the transit router.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The ID of the CIDR block.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/462772.html">ListTransitRouterCidr</a> operation to query the ID of a CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidr-0zv0q9crqpntzz****</para>
        /// </summary>
        [NameInMap("TransitRouterCidrId")]
        [Validation(Required=false)]
        public string TransitRouterCidrId { get; set; }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-p0w3x8c9em72a40nw****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
