// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Return data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClusterCheckSummaryResponseBodyData Data { get; set; }
        public class GetClusterCheckSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Total number of items that failed the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("NotPassCount")]
            [Validation(Required=false)]
            public int? NotPassCount { get; set; }

            /// <summary>
            /// <para>Number of high-risk inspection items that have not passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NotPassHighCount")]
            [Validation(Required=false)]
            public int? NotPassHighCount { get; set; }

            /// <summary>
            /// <para>Number of low-risk inspection items that have not passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NotPassLowCount")]
            [Validation(Required=false)]
            public int? NotPassLowCount { get; set; }

            /// <summary>
            /// <para>Number of medium-risk failed inspection items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NotPassMediumCount")]
            [Validation(Required=false)]
            public int? NotPassMediumCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
