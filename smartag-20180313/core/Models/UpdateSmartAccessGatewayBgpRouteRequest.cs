// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UpdateSmartAccessGatewayBgpRouteRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query only the SAG instances that belong to another Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossAccount")]
        [Validation(Required=false)]
        public bool? CrossAccount { get; set; }

        /// <summary>
        /// <para>The hold time. Unit: seconds.</para>
        /// <para>Valid values: <b>3</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para>When the SAG device establishes a peering connection with a peer device, the hold time of both devices must be the same. If the SAG device does not receive a keepalive or update message from the peer device within the hold time, the connection between the BGP peers is closed.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("HoldTime")]
        [Validation(Required=false)]
        public int? HoldTime { get; set; }

        /// <summary>
        /// <para>The time interval at which keep-alive packets are sent. Unit: seconds.</para>
        /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public int? KeepAlive { get; set; }

        /// <summary>
        /// <para>The autonomous system number (ASN) of the SAG device.</para>
        /// <para>Valid values: <b>1</b> to <b>4294967295</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65536</para>
        /// </summary>
        [NameInMap("LocalAs")]
        [Validation(Required=false)]
        public long? LocalAs { get; set; }

        /// <summary>
        /// <para>The region ID of the SAG instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the SAG instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>147304382796****</para>
        /// </summary>
        [NameInMap("ResourceUid")]
        [Validation(Required=false)]
        public string ResourceUid { get; set; }

        /// <summary>
        /// <para>The ID of the BGP router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.1</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway (SAG) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-v9un1ccz22owd7****</para>
        /// </summary>
        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sagf4dk****</para>
        /// </summary>
        [NameInMap("SagSn")]
        [Validation(Required=false)]
        public string SagSn { get; set; }

    }

}
