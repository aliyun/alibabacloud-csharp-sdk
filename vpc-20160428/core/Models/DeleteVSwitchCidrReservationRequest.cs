// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteVSwitchCidrReservationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the resource. The system checks whether the required parameters are specified, whether the request format is valid, and whether business restrictions are met. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check passes, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the vSwitch.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
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
        /// <para>The instance ID of the reserved vSwitch CIDR block to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcr-bp1m12saqteraw3rp****</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationId")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationId { get; set; }

    }

}
