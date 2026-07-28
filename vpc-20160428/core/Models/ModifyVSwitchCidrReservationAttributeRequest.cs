// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVSwitchCidrReservationAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-230e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and business restrictions. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The description of the reserved CIDR block for a vSwitch that you want to modify. If you do not specify this parameter, the description is empty. The default value is empty.</para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReservationDescription</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationDescription")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationDescription { get; set; }

        /// <summary>
        /// <para>The instance ID of the reserved CIDR block for a vSwitch that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcr-bp1m12saqteraw3rp****</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationId")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationId { get; set; }

        /// <summary>
        /// <para>The name of the reserved CIDR block for a vSwitch that you want to modify.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReservationName</para>
        /// </summary>
        [NameInMap("VSwitchCidrReservationName")]
        [Validation(Required=false)]
        public string VSwitchCidrReservationName { get; set; }

    }

}
