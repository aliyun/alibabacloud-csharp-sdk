// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataArchiveCountResponseBodyData Data { get; set; }
        public class GetDataArchiveCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of tickets that data archiving failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// <para>The number of tickets that data archiving is in progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2**</para>
            /// </summary>
            [NameInMap("ProcessingCount")]
            [Validation(Required=false)]
            public long? ProcessingCount { get; set; }

            /// <summary>
            /// <para>The number of tickets that data archiving is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3**</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// <para>The total number of data archiving tickets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6**</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B63CAC5-BD7F-5C7C-82C9-59DFFBC3C5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
