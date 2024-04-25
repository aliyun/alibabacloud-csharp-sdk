// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogStatisticResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// SqlLogStatistic
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogStatisticResponseBodyData Data { get; set; }
        public class DescribeSqlLogStatisticResponseBodyData : TeaModel {
            [NameInMap("ColdSqlSize")]
            [Validation(Required=false)]
            public long? ColdSqlSize { get; set; }

            [NameInMap("FreeColdSqlSize")]
            [Validation(Required=false)]
            public long? FreeColdSqlSize { get; set; }

            [NameInMap("FreeHotSqlSize")]
            [Validation(Required=false)]
            public long? FreeHotSqlSize { get; set; }

            [NameInMap("HotSqlSize")]
            [Validation(Required=false)]
            public long? HotSqlSize { get; set; }

            [NameInMap("ImportSqlSize")]
            [Validation(Required=false)]
            public long? ImportSqlSize { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
