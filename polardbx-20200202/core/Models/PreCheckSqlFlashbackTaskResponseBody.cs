// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class PreCheckSqlFlashbackTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PreCheckSqlFlashbackTaskResponseBodyData Data { get; set; }
        public class PreCheckSqlFlashbackTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The check result.</para>
            /// </summary>
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public PreCheckSqlFlashbackTaskResponseBodyDataCheckResult CheckResult { get; set; }
            public class PreCheckSqlFlashbackTaskResponseBodyDataCheckResult : TeaModel {
                /// <summary>
                /// <para>Indicates whether valid binary log files exist. This value is used to determine whether operations such as flashback and synchronization can be performed.</para>
                /// </summary>
                [NameInMap("BinlogExists")]
                [Validation(Required=false)]
                public bool? BinlogExists { get; set; }

                /// <summary>
                /// <para>Indicates whether the recording of original SQL query events is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("BinlogRowQueryEventEnabled")]
                [Validation(Required=false)]
                public bool? BinlogRowQueryEventEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the upgrade can succeed.</para>
                /// </summary>
                [NameInMap("CanUpgradeSupportBinlogRowQueryEvents")]
                [Validation(Required=false)]
                public bool? CanUpgradeSupportBinlogRowQueryEvents { get; set; }

                /// <summary>
                /// <para>Indicates whether the table exists. Valid values: true and false.</para>
                /// </summary>
                [NameInMap("HasTable")]
                [Validation(Required=false)]
                public bool? HasTable { get; set; }

                /// <summary>
                /// <para>Indicates whether log recording is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Supported.</description></item>
                /// <item><description><b>false</b>: Not supported.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SupportBinlogRowQueryEvents")]
                [Validation(Required=false)]
                public bool? SupportBinlogRowQueryEvents { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message. This parameter is empty when the request succeeds. If the request fails, an exception message is returned, such as an error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successs</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14036EBE-***-44DB-ACE9-AC6157D3A6FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
