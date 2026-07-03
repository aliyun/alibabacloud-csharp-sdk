// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeImportedLogCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImportedLogCountResponseBodyData Data { get; set; }
        public class DescribeImportedLogCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of ingested logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ImportedLogCount")]
            [Validation(Required=false)]
            public int? ImportedLogCount { get; set; }

            /// <summary>
            /// <para>The total number of logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59</para>
            /// </summary>
            [NameInMap("TotalLogCount")]
            [Validation(Required=false)]
            public int? TotalLogCount { get; set; }

            /// <summary>
            /// <para>The number of logs that are not ingested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49</para>
            /// </summary>
            [NameInMap("UnImportedLogCount")]
            [Validation(Required=false)]
            public int? UnImportedLogCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
