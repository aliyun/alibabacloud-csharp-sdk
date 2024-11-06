// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class OpenDcdnServiceRequest : TeaModel {
        /// <summary>
        /// <para>The metering method of DCDN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-traffic</description></item>
        /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The metering method of WebSocket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>websockettraffic</b>: pay-by-data-transfer</description></item>
        /// <item><description><b>websocketbps</b>: pay-by-bandwidth</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>websockettraffic</para>
        /// </summary>
        [NameInMap("WebsocketBillType")]
        [Validation(Required=false)]
        public string WebsocketBillType { get; set; }

    }

}
