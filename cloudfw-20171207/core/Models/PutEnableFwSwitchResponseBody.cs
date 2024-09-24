// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutEnableFwSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The status information of the asset when it is not synchronized to Cloud Firewall.</para>
        /// </summary>
        [NameInMap("AbnormalResourceStatusList")]
        [Validation(Required=false)]
        public List<PutEnableFwSwitchResponseBodyAbnormalResourceStatusList> AbnormalResourceStatusList { get; set; }
        public class PutEnableFwSwitchResponseBodyAbnormalResourceStatusList : TeaModel {
            /// <summary>
            /// <para>The message displayed when the asset is not synchronized to Cloud Firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloudfirewall do not sync this ip address: This IP address is not synchronized to Cloud Firewall.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloudfirewall do not sync this ip address</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.0.113.0</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The status of the asset when it is not synchronized to Cloud Firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ip_not_sync: The asset is not synchronized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip_not_sync</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2841452-CB8D-4F7D-B247-38E1CF7334F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
