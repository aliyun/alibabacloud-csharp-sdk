// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Domain configuration details.</para>
        /// </summary>
        [NameInMap("DomainConfig")]
        [Validation(Required=false)]
        public DescribeVsDomainDetailResponseBodyDomainConfig DomainConfig { get; set; }
        public class DescribeVsDomainDetailResponseBodyDomainConfig : TeaModel {
            /// <summary>
            /// <para>The CNAME assigned to the Visual Edge Computing Service domain. You must configure your DNS provider to point your domain to this CNAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com.*****.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试使用</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Visual Edge Computing Service domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The status of the Visual Edge Computing Service accelerated domain. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>configuring</b>: Being configured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// <para>The domain type.</para>
            /// <remarks>
            /// <para>Static value: vs</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vs</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-19T10:27:23Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The most recent modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-19T10:27:23Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The region where the domain is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTPS is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b> (default): Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }

            /// <summary>
            /// <para>The acceleration region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>domestic</b></para>
            /// </description></item>
            /// <item><description><para><b>overseas</b></para>
            /// </description></item>
            /// <item><description><para><b>global</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BEC5E85-C76B-56EF-A922-860EFDB8B64B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
