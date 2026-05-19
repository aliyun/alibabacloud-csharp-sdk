// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnTaskListResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeCdnTaskListResponseBodyContent Content { get; set; }
        public class DescribeCdnTaskListResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeCdnTaskListResponseBodyContentList> List { get; set; }
            public class DescribeCdnTaskListResponseBodyContentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1077********7468</para>
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public string Aliuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("ClientAddr")]
                [Validation(Required=false)]
                public string ClientAddr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx.xx.xx.xx</para>
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-12-10 15:11:47</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f2a18ad5</para>
                /// </summary>
                [NameInMap("DiagnoseId")]
                [Validation(Required=false)]
                public string DiagnoseId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://cdn.dns-detect.alicdn.com/diagnose/xxxxxx">http://cdn.dns-detect.alicdn.com/diagnose/xxxxxx</a></para>
                /// </summary>
                [NameInMap("DiagnoseUrl")]
                [Validation(Required=false)]
                public string DiagnoseUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">http://www.example.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1669285111</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RemainDiagnoseTimes")]
                [Validation(Required=false)]
                public long? RemainDiagnoseTimes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>000000xxxxxxxxxxxxxxxxxxxxxxxxxxxx475e</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1s</para>
                /// </summary>
                [NameInMap("TimeConsuming")]
                [Validation(Required=false)]
                public long? TimeConsuming { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>000000xxxxxxxxxxxxxxxxxxxxxx25941e</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4E09C5D7-E1CF-4CAA-A45E-8727F4C8FD70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
