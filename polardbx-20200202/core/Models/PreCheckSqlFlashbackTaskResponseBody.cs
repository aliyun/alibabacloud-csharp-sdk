// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class PreCheckSqlFlashbackTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PreCheckSqlFlashbackTaskResponseBodyData Data { get; set; }
        public class PreCheckSqlFlashbackTaskResponseBodyData : TeaModel {
            [NameInMap("CheckResult")]
            [Validation(Required=false)]
            public PreCheckSqlFlashbackTaskResponseBodyDataCheckResult CheckResult { get; set; }
            public class PreCheckSqlFlashbackTaskResponseBodyDataCheckResult : TeaModel {
                [NameInMap("BinlogExists")]
                [Validation(Required=false)]
                public bool? BinlogExists { get; set; }

                [NameInMap("BinlogRowQueryEventEnabled")]
                [Validation(Required=false)]
                public bool? BinlogRowQueryEventEnabled { get; set; }

                [NameInMap("CanUpgradeSupportBinlogRowQueryEvents")]
                [Validation(Required=false)]
                public bool? CanUpgradeSupportBinlogRowQueryEvents { get; set; }

                [NameInMap("HasTable")]
                [Validation(Required=false)]
                public bool? HasTable { get; set; }

                [NameInMap("SupportBinlogRowQueryEvents")]
                [Validation(Required=false)]
                public bool? SupportBinlogRowQueryEvents { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successs</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14036EBE-***-44DB-ACE9-AC6157D3A6FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
