// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeOfficeSitesResponseBody : TeaModel {
        /// <summary>
        /// <para>The office networks.</para>
        /// </summary>
        [NameInMap("OfficeSites")]
        [Validation(Required=false)]
        public List<DescribeOfficeSitesResponseBodyOfficeSites> OfficeSites { get; set; }
        public class DescribeOfficeSitesResponseBodyOfficeSites : TeaModel {
            /// <summary>
            /// <para>aliuid</para>
            /// 
            /// <b>Example:</b>
            /// <para>125552</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>biztype</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENTERPRISE</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// <para>The allowed connection types for accessing the office network.</para>
            /// <remarks>
            /// <para>The VPC connection type depends on the Alibaba Cloud PrivateLink service, which incurs no fee. When this parameter is set to VPC or Any, the system automatically enables the PrivateLink service for you.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// <para>The endpoint used when connecting to cloud desktops through a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com">http://ep-bp1s2vmbj55r5rzc****.epsrv-bp1pcfhpwvlpny01****.cn-hangzhou.privatelink.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            /// <summary>
            /// <para>Office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The type of account system used by the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <para>User Account BID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>268****</para>
            /// </summary>
            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            /// <summary>
            /// <para>SSO connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://eds-cn-shanghai-67">https://eds-cn-shanghai-67</a>****</para>
            /// </summary>
            [NameInMap("SsoServiceUrl")]
            [Validation(Required=false)]
            public string SsoServiceUrl { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
