// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class UpgradeMinorVersionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpgradeMinorVersionResponseBodyData Data { get; set; }
        public class UpgradeMinorVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cc-uf6x229yeq166****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE242962-6DA3-5FC8-9691-37B62A3210F7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
