// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDiagnoseReportResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeCdnDiagnoseReportResponseBodyContent Content { get; set; }
        public class DescribeCdnDiagnoseReportResponseBodyContent : TeaModel {
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

            [NameInMap("ClientInfo")]
            [Validation(Required=false)]
            public DescribeCdnDiagnoseReportResponseBodyContentClientInfo ClientInfo { get; set; }
            public class DescribeCdnDiagnoseReportResponseBodyContentClientInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Chrome</para>
                /// </summary>
                [NameInMap("BrowserInfo")]
                [Validation(Required=false)]
                public string BrowserInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Macintosh</para>
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mozilla/5.0 (Macintosh Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36</para>
                /// </summary>
                [NameInMap("UAString")]
                [Validation(Required=false)]
                public string UAString { get; set; }

            }

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
            /// <para>f2xxxxd5</para>
            /// </summary>
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }

            [NameInMap("DiagnoseReportLink")]
            [Validation(Required=false)]
            public string DiagnoseReportLink { get; set; }

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
            /// <para>1678701915</para>
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

            [NameInMap("Report")]
            [Validation(Required=false)]
            public DescribeCdnDiagnoseReportResponseBodyContentReport Report { get; set; }
            public class DescribeCdnDiagnoseReportResponseBodyContentReport : TeaModel {
                [NameInMap("ClientInfo")]
                [Validation(Required=false)]
                public string ClientInfo { get; set; }

                [NameInMap("DiagnoseResult")]
                [Validation(Required=false)]
                public string DiagnoseResult { get; set; }

                [NameInMap("L1Node")]
                [Validation(Required=false)]
                public string L1Node { get; set; }

                [NameInMap("L1Tengine")]
                [Validation(Required=false)]
                public DescribeCdnDiagnoseReportResponseBodyContentReportL1Tengine L1Tengine { get; set; }
                public class DescribeCdnDiagnoseReportResponseBodyContentReportL1Tengine : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>150.xxx.xxx.197:81</para>
                    /// </summary>
                    [NameInMap("Addr")]
                    [Validation(Required=false)]
                    public string Addr { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Unmatched CNAME.</para>
                    /// </summary>
                    [NameInMap("ErrorLog")]
                    [Validation(Required=false)]
                    public string ErrorLog { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>107ms</para>
                    /// </summary>
                    [NameInMap("Fbt")]
                    [Validation(Required=false)]
                    public string Fbt { get; set; }

                    [NameInMap("Intro")]
                    [Validation(Required=false)]
                    public string Intro { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>aG9zd******8tbWVtYmV</para>
                    /// </summary>
                    [NameInMap("ReqHeader")]
                    [Validation(Required=false)]
                    public string ReqHeader { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-02-06 12:17:47</para>
                    /// </summary>
                    [NameInMap("ReqTime")]
                    [Validation(Required=false)]
                    public string ReqTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>U2VydmV*******Qo</para>
                    /// </summary>
                    [NameInMap("RespHeader")]
                    [Validation(Required=false)]
                    public string RespHeader { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2892</para>
                    /// </summary>
                    [NameInMap("RespSize")]
                    [Validation(Required=false)]
                    public long? RespSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>107ms</para>
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public string Rt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn4461</para>
                    /// </summary>
                    [NameInMap("Station")]
                    [Validation(Required=false)]
                    public string Station { get; set; }

                }

                [NameInMap("SourceInfo")]
                [Validation(Required=false)]
                public List<string> SourceInfo { get; set; }

            }

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
            /// <para>xxxxxxx-xxxxx-xxxxx-xxxxxxxxxxx</para>
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
            /// <para><a href="https://tracing-sk.alibaba-inc.com/trace/xxxxxxxxxxxxxx">https://tracing-sk.alibaba-inc.com/trace/xxxxxxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("TraceDisplayLink")]
            [Validation(Required=false)]
            public string TraceDisplayLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0000006xxxxxxxxxxxx533427e</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64D28B53-xxxxx-xxx-xxxxx-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
