// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class CreateErRouteMapRequest : TeaModel {
        /// <summary>
        /// <para>Policy description</para>
        /// 
        /// <b>Example:</b>
        /// <para>terraform-example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Destination CIDR Block</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Lingjun HUB ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-aueyxxsy</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>The ID of the destination instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-xlhsvdvt</para>
        /// </summary>
        [NameInMap("ReceptionInstanceId")]
        [Validation(Required=false)]
        public string ReceptionInstanceId { get; set; }

        /// <summary>
        /// <para>The tenant to which the route receiving instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620939556166277</para>
        /// </summary>
        [NameInMap("ReceptionInstanceOwner")]
        [Validation(Required=false)]
        public string ReceptionInstanceOwner { get; set; }

        /// <summary>
        /// <para>The type of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPD</b>: Lingjun network segment.</description></item>
        /// <item><description><b>VCC</b>: Lingjun Connection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPD</para>
        /// </summary>
        [NameInMap("ReceptionInstanceType")]
        [Validation(Required=false)]
        public string ReceptionInstanceType { get; set; }

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
        /// <para>Policy behavior; optional values:</para>
        /// <list type="bullet">
        /// <item><description><b>permit</b>: Allow</description></item>
        /// <item><description><b>deny</b>: Rejected</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>permit</para>
        /// </summary>
        [NameInMap("RouteMapAction")]
        [Validation(Required=false)]
        public string RouteMapAction { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <para>A smaller sequence number indicates a lower priority. When a route is matched, a policy with a higher priority is preferentially matched.</para>
        /// <para><b>Valid values: 1001 to 2000</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("RouteMapNum")]
        [Validation(Required=false)]
        public int? RouteMapNum { get; set; }

        /// <summary>
        /// <para>The ID of the source instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-xlsjsdvt</para>
        /// </summary>
        [NameInMap("TransmissionInstanceId")]
        [Validation(Required=false)]
        public string TransmissionInstanceId { get; set; }

        /// <summary>
        /// <para>The tenant to which the route publish instance belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620939556166277</para>
        /// </summary>
        [NameInMap("TransmissionInstanceOwner")]
        [Validation(Required=false)]
        public string TransmissionInstanceOwner { get; set; }

        /// <summary>
        /// <para>The type of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPD</b>: Lingjun network segment.</description></item>
        /// <item><description><b>VCC</b>: Lingjun Connection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPD</para>
        /// </summary>
        [NameInMap("TransmissionInstanceType")]
        [Validation(Required=false)]
        public string TransmissionInstanceType { get; set; }

    }

}
