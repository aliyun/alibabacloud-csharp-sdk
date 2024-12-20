// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListHotlineRecordDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public ListHotlineRecordDetailResponseBodyResultData ResultData { get; set; }
        public class ListHotlineRecordDetailResponseBodyResultData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListHotlineRecordDetailResponseBodyResultDataData> Data { get; set; }
            public class ListHotlineRecordDetailResponseBodyResultDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1614578410000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx.xxxxx/xx.wav">http://xxx.xxxxx/xx.wav</a></para>
                /// </summary>
                [NameInMap("OssUrl")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:123@123.com">123@123.com</a></para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1614578400000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public long? OnePageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>945</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public long? TotalResults { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
