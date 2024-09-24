// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ResetLogShipperRequest : TeaModel {
        /// <summary>
        /// <para>The global retention period of hot data.</para>
        /// <remarks>
        /// <para> The value of this parameter must be at least 7 and smaller than the log retention period. Unit: days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("HotTtl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>The settings of the log analysis feature.</para>
        /// </summary>
        [NameInMap("LogMetaList")]
        [Validation(Required=false)]
        public List<ResetLogShipperRequestLogMetaList> LogMetaList { get; set; }
        public class ResetLogShipperRequestLogMetaList : TeaModel {
            /// <summary>
            /// <para>The Logstore that you want to configure.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeLogMeta~~">DescribeLogMeta</a> operation to query the Logstore.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sas-security-log</para>
            /// </summary>
            [NameInMap("ConfigLogStore")]
            [Validation(Required=false)]
            public string ConfigLogStore { get; set; }

            /// <summary>
            /// <para>The retention period of hot data in the Logstore.</para>
            /// <remarks>
            /// <para> The value of this parameter must be at least 7 and smaller than the log retention period. Unit: days. If you specify this parameter for the Logstore, the global retention period of hot data specified by the HotTtl parameter is overwritten.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("HotTtl")]
            [Validation(Required=false)]
            public int? HotTtl { get; set; }

            /// <summary>
            /// <para>The status of the log analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b></description></item>
            /// <item><description><b>enabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The log retention period of the Logstore.</para>
            /// <remarks>
            /// <para> If you specify this parameter for the Logstore, the global log retention period specified by the Ttl parameter is overwritten.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <para>The global log retention period.</para>
        /// <remarks>
        /// <para> This parameter is supported only when the log analysis feature uses the pay-as-you-go billing method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
