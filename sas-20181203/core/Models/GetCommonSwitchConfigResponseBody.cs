// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCommonSwitchConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCommonSwitchConfigResponseBodyData Data { get; set; }
        public class GetCommonSwitchConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether to turn on the switch for newly added servers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: By default, the switch is turned on for newly added servers.</description></item>
            /// <item><description><b>del</b>: By default, the switch is turned off for newly added servers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("TargetDefault")]
            [Validation(Required=false)]
            public string TargetDefault { get; set; }

            /// <summary>
            /// <para>The status of the synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sync</b>: The modifications are being synchronized.</description></item>
            /// <item><description><b>valid</b>: The modifications has taken effect.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("TargetSyncStatus")]
            [Validation(Required=false)]
            public string TargetSyncStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
