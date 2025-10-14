// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSqlAuditInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlAuditInfoResponseBodyData Data { get; set; }
        public class DescribeSqlAuditInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public bool? IsEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polardbx-sqlaudit-log</para>
            /// </summary>
            [NameInMap("SLSLogStore")]
            [Validation(Required=false)]
            public string SLSLogStore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polardbx-sqlaudit-cn-hangzhou-123456789</para>
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DC3ABA3E-0F8A-4596-9104-F5155C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
