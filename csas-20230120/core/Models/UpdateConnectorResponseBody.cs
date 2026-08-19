// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateConnectorResponseBody : TeaModel {
        /// <summary>
        /// <para>Connector。</para>
        /// </summary>
        [NameInMap("Connector")]
        [Validation(Required=false)]
        public UpdateConnectorResponseBodyConnector Connector { get; set; }
        public class UpdateConnectorResponseBodyConnector : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable Global Accelerator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("AccelerateStatus")]
            [Validation(Required=false)]
            public string AccelerateStatus { get; set; }

            /// <summary>
            /// <para>ConnectorID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-94db94e06b98****</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <para>The creation time of the Connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-16 17:18:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Connector name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The connection status of the Connector. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Online</b>: Online.</description></item>
            /// <item><description><b>Offline</b>: Offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance status of the Connector. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b>: Enabled.</description></item>
            /// <item><description><b>Disabled</b>: Shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            /// <summary>
            /// <para>The upgrade time of the Connector.</para>
            /// </summary>
            [NameInMap("UpgradeTime")]
            [Validation(Required=false)]
            public UpdateConnectorResponseBodyConnectorUpgradeTime UpgradeTime { get; set; }
            public class UpdateConnectorResponseBodyConnectorUpgradeTime : TeaModel {
                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:00</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20:00</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>The virtual IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("VipCidr")]
            [Validation(Required=false)]
            public string VipCidr { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
