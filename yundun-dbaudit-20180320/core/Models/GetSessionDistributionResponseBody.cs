// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetSessionDistributionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeList")]
        [Validation(Required=false)]
        public List<GetSessionDistributionResponseBodyTimeList> TimeList { get; set; }
        public class GetSessionDistributionResponseBodyTimeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public long? ActiveSessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("BeginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 01:00:00</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("ErrorSessionCount")]
            [Validation(Required=false)]
            public long? ErrorSessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("LoginSessionCount")]
            [Validation(Required=false)]
            public long? LoginSessionCount { get; set; }

        }

    }

}
