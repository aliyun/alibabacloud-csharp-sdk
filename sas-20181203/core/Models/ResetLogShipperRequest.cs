// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ResetLogShipperRequest : TeaModel {
        /// <summary>
        /// <para>The global data retention period in the hot storage tier.</para>
        /// <remarks>
        /// <para>Valid values: greater than or equal to 7 days and less than the log retention period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("HotTtl")]
        [Validation(Required=false)]
        public int? HotTtl { get; set; }

        /// <summary>
        /// <para>The configuration information for log analysis in Security Center.</para>
        /// </summary>
        [NameInMap("LogMetaList")]
        [Validation(Required=false)]
        public List<ResetLogShipperRequestLogMetaList> LogMetaList { get; set; }
        public class ResetLogShipperRequestLogMetaList : TeaModel {
            /// <summary>
            /// <para>The Logstore to be configured.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeLogMeta~~">DescribeLogMeta</a> operation to obtain the value of this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sas-security-log</para>
            /// </summary>
            [NameInMap("ConfigLogStore")]
            [Validation(Required=false)]
            public string ConfigLogStore { get; set; }

            /// <summary>
            /// <para>The data retention period in the hot storage tier of the Logstore.</para>
            /// <remarks>
            /// <para>Valid values: greater than or equal to 7 days and less than the log retention period. Specifying the data retention period in the hot storage tier for a single Logstore overrides the global settings.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("HotTtl")]
            [Validation(Required=false)]
            public int? HotTtl { get; set; }

            /// <summary>
            /// <para>The current enabling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: The feature is disabled.</description></item>
            /// <item><description><b>enabled</b>: The feature is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The log retention period of the Logstore in days.</para>
            /// <remarks>
            /// <para>Specifying the log retention period for a single Logstore overrides the global settings.</para>
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
        /// <para>The global log retention period in days.</para>
        /// <remarks>
        /// <para>This parameter is supported only in the pay-as-you-go billing mode for logs.</para>
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
