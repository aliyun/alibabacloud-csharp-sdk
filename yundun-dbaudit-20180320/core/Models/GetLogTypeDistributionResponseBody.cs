// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogTypeDistributionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8EC13467-A84C-401F-A4A0-AF893066FBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeList")]
        [Validation(Required=false)]
        public List<GetLogTypeDistributionResponseBodyTimeList> TimeList { get; set; }
        public class GetLogTypeDistributionResponseBodyTimeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("BeginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("DeleteSqlCount")]
            [Validation(Required=false)]
            public long? DeleteSqlCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 01:00:00</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500000</para>
            /// </summary>
            [NameInMap("ExecCostUS")]
            [Validation(Required=false)]
            public string ExecCostUS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("InsertSqlCount")]
            [Validation(Required=false)]
            public long? InsertSqlCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("OtherSqlCount")]
            [Validation(Required=false)]
            public long? OtherSqlCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("SelectSqlCount")]
            [Validation(Required=false)]
            public long? SelectSqlCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("UpdateSqlCount")]
            [Validation(Required=false)]
            public long? UpdateSqlCount { get; set; }

        }

    }

}
