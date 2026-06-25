// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationSlbsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>2xx</c>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><c>3xx</c>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><c>4xx</c>: A client error occurs.</para>
        /// </description></item>
        /// <item><description><para><c>5xx</c>: A server error occurs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationSlbsResponseBodyData Data { get; set; }
        public class DescribeApplicationSlbsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The configurations of the Internet-facing SLB instance.</para>
            /// </summary>
            [NameInMap("Internet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataInternet> Internet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataInternet : TeaModel {
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

                /// <summary>
                /// <para>The cookie that is configured on the server.</para>
                /// <para>The cookie must be 1 to 200 characters in length and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), or spaces. It cannot start with a dollar sign ($).</para>
                /// <remarks>
                /// <para>This parameter is required when <c>StickySession</c> is set to <c>true</c> and <c>StickySessionType</c> is set to <c>server</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>wwe</para>
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// <para>The cookie timeout period. Unit: seconds. Valid values: <c>1</c> to <c>86400</c>.</para>
                /// <remarks>
                /// <para>This parameter is required when <c>StickySession</c> is set to <c>true</c> and <c>StickySessionType</c> is set to <c>insert</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                /// <summary>
                /// <para>The time when the rule was created. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1741247308294</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("EnableConnectionDrain")]
                [Validation(Required=false)]
                public bool? EnableConnectionDrain { get; set; }

                /// <summary>
                /// <para>The ID of the CA certificate for the HTTPS protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1513561019707729_16f37aae5f3_-375882821_-169099****</para>
                /// </summary>
                [NameInMap("HttpsCaCertId")]
                [Validation(Required=false)]
                public string HttpsCaCertId { get; set; }

                /// <summary>
                /// <para>The ID of the certificate for the HTTPS protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1513561019707729_16f37aae5f3_-375882821_-169099****</para>
                /// </summary>
                [NameInMap("HttpsCertId")]
                [Validation(Required=false)]
                public string HttpsCertId { get; set; }

                /// <summary>
                /// <para>The listening port of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The supported protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Indicates whether session persistence is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public bool? StickySession { get; set; }

                /// <summary>
                /// <para>The cookie handling method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>insert</c>: inserts a cookie. When a client makes the first request, the SLB instance inserts a cookie into the response. The next request from the client contains the cookie, and the SLB instance forwards the request to the same backend server.</para>
                /// </description></item>
                /// <item><description><para><c>server</c>: rewrites a cookie. When the SLB instance detects a user-defined cookie, it rewrites the cookie. The next request from the client contains the new cookie, and the SLB instance forwards the request to the same backend server.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is required when <c>StickySession</c> is set to <c>true</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>insert</para>
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// <para>The container port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>59.74.**.**</c></para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The billing method of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayBySpec</para>
            /// </summary>
            [NameInMap("InternetSlbChargeType")]
            [Validation(Required=false)]
            public string InternetSlbChargeType { get; set; }

            /// <summary>
            /// <para>Indicates whether the Internet-facing SLB instance has expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("InternetSlbExpired")]
            [Validation(Required=false)]
            public bool? InternetSlbExpired { get; set; }

            /// <summary>
            /// <para>The ID of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf6xc7wybefehnv45****</para>
            /// </summary>
            [NameInMap("InternetSlbId")]
            [Validation(Required=false)]
            public string InternetSlbId { get; set; }

            /// <summary>
            /// <para>The configurations of the internal-facing SLB instance.</para>
            /// </summary>
            [NameInMap("Intranet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataIntranet> Intranet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataIntranet : TeaModel {
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

                /// <summary>
                /// <para>The cookie that is configured on the server.</para>
                /// <para>The cookie must be 1 to 200 characters in length and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), or spaces. It cannot start with a dollar sign ($).</para>
                /// <remarks>
                /// <para>This parameter is required when <c>StickySession</c> is set to <c>true</c> and <c>StickySessionType</c> is set to <c>server</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>wwe</para>
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// <para>The cookie timeout period. Unit: seconds. Valid values: <c>1</c> to <c>86400</c>.</para>
                /// <remarks>
                /// <para>This parameter is required when <c>StickySession</c> is set to <c>true</c> and <c>StickySessionType</c> is set to <c>insert</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                /// <summary>
                /// <para>The time when the rule was created. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1741247308294</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("EnableConnectionDrain")]
                [Validation(Required=false)]
                public bool? EnableConnectionDrain { get; set; }

                /// <summary>
                /// <para>The ID of the CA certificate for the HTTPS protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1513561019707729_16f37aae5f3_-375882821_-169099****</para>
                /// </summary>
                [NameInMap("HttpsCaCertId")]
                [Validation(Required=false)]
                public string HttpsCaCertId { get; set; }

                /// <summary>
                /// <para>The ID of the certificate for the HTTPS protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1513561019707729_16f37aae5f3_-375882821_-169099****</para>
                /// </summary>
                [NameInMap("HttpsCertId")]
                [Validation(Required=false)]
                public string HttpsCertId { get; set; }

                /// <summary>
                /// <para>The listening port of the SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The supported protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Indicates whether session persistence is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public bool? StickySession { get; set; }

                /// <summary>
                /// <para>The cookie handling method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>insert</c>: inserts a cookie. When a client makes the first request, the SLB instance inserts a cookie into the response. The next request from the client contains the cookie, and the SLB instance forwards the request to the same backend server.</para>
                /// </description></item>
                /// <item><description><para><c>server</c>: rewrites a cookie. When the SLB instance detects a user-defined cookie, it rewrites the cookie. The next request from the client contains the new cookie, and the SLB instance forwards the request to the same backend server.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is required when <c>StickySession</c> is set to <c>true</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>insert</para>
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// <para>The container port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

            }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The billing method of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayBySpec</para>
            /// </summary>
            [NameInMap("IntranetSlbChargeType")]
            [Validation(Required=false)]
            public string IntranetSlbChargeType { get; set; }

            /// <summary>
            /// <para>Indicates whether the internal-facing SLB instance has expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IntranetSlbExpired")]
            [Validation(Required=false)]
            public bool? IntranetSlbExpired { get; set; }

            /// <summary>
            /// <para>The ID of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf6xc7wybefehnv45****</para>
            /// </summary>
            [NameInMap("IntranetSlbId")]
            [Validation(Required=false)]
            public string IntranetSlbId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <c>success</c> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, a specific error code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the configuration of the SLB instance was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The configuration was obtained.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The configuration failed to be obtained.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
