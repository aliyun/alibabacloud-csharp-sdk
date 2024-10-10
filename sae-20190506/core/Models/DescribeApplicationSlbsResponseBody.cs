// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationSlbsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the information about the SLB instances that are associated with an application was obtained successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the information was obtained successfully.</description></item>
        /// <item><description><b>false</b>: indicates that the information failed to be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Configurations of internal-facing SLB instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationSlbsResponseBodyData Data { get; set; }
        public class DescribeApplicationSlbsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the SSL certificate issued by Alibaba Cloud.</para>
            /// </summary>
            [NameInMap("Internet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataInternet> Internet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataInternet : TeaModel {
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                [NameInMap("HttpsCaCertId")]
                [Validation(Required=false)]
                public string HttpsCaCertId { get; set; }

                /// <summary>
                /// <para>The supported protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1513561019707729_16f37aae5f3_-375882821_-169099****</para>
                /// </summary>
                [NameInMap("HttpsCertId")]
                [Validation(Required=false)]
                public string HttpsCertId { get; set; }

                /// <summary>
                /// <para>The ID of the internal-facing SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The container port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public bool? StickySession { get; set; }

                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// <para>The port specified for the SLB listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59.74.**.**</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("InternetSlbChargeType")]
            [Validation(Required=false)]
            public string InternetSlbChargeType { get; set; }

            [NameInMap("InternetSlbExpired")]
            [Validation(Required=false)]
            public bool? InternetSlbExpired { get; set; }

            /// <summary>
            /// <para>Configurations of Internet-facing SLB instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf6xc7wybefehnv45****</para>
            /// </summary>
            [NameInMap("InternetSlbId")]
            [Validation(Required=false)]
            public string InternetSlbId { get; set; }

            /// <summary>
            /// <para>The ID of the SSL certificate issued by Alibaba Cloud.</para>
            /// </summary>
            [NameInMap("Intranet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataIntranet> Intranet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataIntranet : TeaModel {
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                [NameInMap("HttpsCaCertId")]
                [Validation(Required=false)]
                public string HttpsCaCertId { get; set; }

                /// <summary>
                /// <para>The supported protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1513561019707729_16f37aae5f3_-375882821_-169099****</para>
                /// </summary>
                [NameInMap("HttpsCertId")]
                [Validation(Required=false)]
                public string HttpsCertId { get; set; }

                /// <summary>
                /// <para>The IP address of the Internet-facing SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The container port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public bool? StickySession { get; set; }

                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// <para>The port specified for the SLB listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// <para>The error code.</para>
            /// <list type="bullet">
            /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
            /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("IntranetSlbChargeType")]
            [Validation(Required=false)]
            public string IntranetSlbChargeType { get; set; }

            [NameInMap("IntranetSlbExpired")]
            [Validation(Required=false)]
            public bool? IntranetSlbExpired { get; set; }

            /// <summary>
            /// <para>The IP address of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf6xc7wybefehnv45****</para>
            /// </summary>
            [NameInMap("IntranetSlbId")]
            [Validation(Required=false)]
            public string IntranetSlbId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It can be used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><b>success</b> is returned when the request succeeds.</description></item>
        /// <item><description>An error code is returned when the request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
