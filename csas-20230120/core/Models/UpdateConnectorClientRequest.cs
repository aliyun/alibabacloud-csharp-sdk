// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateConnectorClientRequest : TeaModel {
        /// <summary>
        /// <para>The connector ID. You can call <a href="~~ListConnectors~~">ListConnectors</a> to query connector IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-94db94e06b98****</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the ConnectorClient device. You can call <a href="~~ListConnectors~~">ListConnectors</a> to query connector information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>672ECBEE-727B-5F43-8D22-90F2BD9E38A7</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>The connection status of the ConnectorClient. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: connected.</description></item>
        /// <item><description><b>Disabled</b>: disconnected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
