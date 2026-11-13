// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutEnableFwSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of status information when assets are not synchronized.</para>
        /// </summary>
        [NameInMap("AbnormalResourceStatusList")]
        [Validation(Required=false)]
        public List<PutEnableFwSwitchResponseBodyAbnormalResourceStatusList> AbnormalResourceStatusList { get; set; }
        public class PutEnableFwSwitchResponseBodyAbnormalResourceStatusList : TeaModel {
            /// <summary>
            /// <para>The message when the asset is not synchronized. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloudfirewall do not sync this ip address: Cloud Firewall does not synchronize this asset IP address.</description></item>
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
            /// <para>The status when the asset is not synchronized. Valid values:</para>
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
        /// <para>Indicates whether the response is a successful dry run precheck. A value of true indicates that only the precheck is completed and no actual changes are made. This field is not returned or is set to false for actual calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2841452-CB8D-4F7D-B247-38E1CF7334F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
