// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddPrivateRegistryResponseBody : TeaModel {
        /// <summary>
        /// <para>The handling result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddPrivateRegistryResponseBodyData Data { get; set; }
        public class AddPrivateRegistryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104***</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The domain name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The ID of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>273698***</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Internet</description></item>
            /// <item><description><b>2</b>: VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public long? NetType { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: HTTP</description></item>
            /// <item><description><b>2</b>: HTTPS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public long? ProtocolType { get; set; }

            /// <summary>
            /// <para>The region ID of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The IP address of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>114.55.**.**</c></para>
            /// </summary>
            [NameInMap("RegistryHostIp")]
            [Validation(Required=false)]
            public string RegistryHostIp { get; set; }

            /// <summary>
            /// <para>The type of the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>harbor</b></description></item>
            /// <item><description><b>quay</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>harbor</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// <para>The version of the image repository. Default value: -. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-</b>: the default version</description></item>
            /// <item><description><b>V1</b></description></item>
            /// <item><description><b>V2</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>V2</para>
            /// </summary>
            [NameInMap("RegistryVersion")]
            [Validation(Required=false)]
            public string RegistryVersion { get; set; }

            /// <summary>
            /// <para>The value of the token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3c3c602c-fa1f-4bc0-992f-b4b2cac7****</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The number of scan tasks that are performed per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TransPerHour")]
            [Validation(Required=false)]
            public int? TransPerHour { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vchkxmf2j9yjt3x2****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
