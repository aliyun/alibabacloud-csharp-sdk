// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSdlEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D19D8F70-D64B-5A95-905A-6073BF4A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("SdlEventDetailList")]
        [Validation(Required=false)]
        public List<DescribeSdlEventDetailResponseBodySdlEventDetailList> SdlEventDetailList { get; set; }
        public class DescribeSdlEventDetailResponseBodySdlEventDetailList : TeaModel {
            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>event-test</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The amount of sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SensitiveDataCnt")]
            [Validation(Required=false)]
            public long? SensitiveDataCnt { get; set; }

            /// <summary>
            /// <para>The sensitivity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S3</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <para>The type of sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Identity Card</para>
            /// </summary>
            [NameInMap("SensitiveType")]
            [Validation(Required=false)]
            public string SensitiveType { get; set; }

            /// <summary>
            /// <para>The time when the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753928907</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
