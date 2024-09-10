// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDataTrendResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataTrendResponseBodyData Data { get; set; }
        public class GetDataTrendResponseBodyData : TeaModel {
            /// <summary>
            /// The statistical timestamps of the trend data.
            /// </summary>
            [NameInMap("DateList")]
            [Validation(Required=false)]
            public List<int?> DateList { get; set; }

            /// <summary>
            /// The statistical dates and time for the trend data.
            /// </summary>
            [NameInMap("DateStrList")]
            [Validation(Required=false)]
            public List<string> DateStrList { get; set; }

            /// <summary>
            /// The returned data.
            /// </summary>
            [NameInMap("ItemList")]
            [Validation(Required=false)]
            public List<GetDataTrendResponseBodyDataItemList> ItemList { get; set; }
            public class GetDataTrendResponseBodyDataItemList : TeaModel {
                /// <summary>
                /// The statistical values of the trend data.
                /// </summary>
                [NameInMap("CountList")]
                [Validation(Required=false)]
                public List<long?> CountList { get; set; }

                /// <summary>
                /// The type of the security data. Valid values:
                /// 
                /// *   **HC_NEW**: the number of new baseline risks.
                /// *   **HC_OPERATE**: the number of handled baseline risks.
                /// *   **VUL_NEW**: the number of new vulnerabilities.
                /// *   **VUL_OPERATE**: the number of handled vulnerabilities.
                /// *   **SUSP_NEW**: the number of new alerts.
                /// *   **SUSP_OPERATE**: the number of handled alerts.
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
