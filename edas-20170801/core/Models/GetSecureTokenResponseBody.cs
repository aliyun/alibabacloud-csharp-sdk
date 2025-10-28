// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetSecureTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-*************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned security token.</para>
        /// </summary>
        [NameInMap("SecureToken")]
        [Validation(Required=false)]
        public GetSecureTokenResponseBodySecureToken SecureToken { get; set; }
        public class GetSecureTokenResponseBodySecureToken : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID used in the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f676f1**************</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The address of Address Server associated with the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>addr-<b><b>-</b></b>.edas.aliyun.com</para>
            /// </summary>
            [NameInMap("AddressServerHost")]
            [Validation(Required=false)]
            public string AddressServerHost { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("BelongRegion")]
            [Validation(Required=false)]
            public string BelongRegion { get; set; }

            /// <summary>
            /// <para>The description of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>”“</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that activated Enterprise Distributed Application Service (EDAS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>11727458********</para>
            /// </summary>
            [NameInMap("EdasId")]
            [Validation(Required=false)]
            public string EdasId { get; set; }

            /// <summary>
            /// <para>The ID of the security token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7279</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the MSE instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse_prepaid_public_cn-tl32p******</para>
            /// </summary>
            [NameInMap("MseInstanceId")]
            [Validation(Required=false)]
            public string MseInstanceId { get; set; }

            /// <summary>
            /// <para>The public endpoint of the MSE registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-aa2******-p.nacos-ans.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("MseInternetAddress")]
            [Validation(Required=false)]
            public string MseInternetAddress { get; set; }

            /// <summary>
            /// <para>The private endpoint of the MSE registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-72******-nacos-ans.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("MseIntranetAddress")]
            [Validation(Required=false)]
            public string MseIntranetAddress { get; set; }

            /// <summary>
            /// <para>The type of the Microservices Engine (MSE) registry.</para>
            /// <list type="bullet">
            /// <item><description>default: the shared registry of EDAS</description></item>
            /// <item><description>exclusive_mse: MSE Nacos registry</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exclusive_mse</para>
            /// </summary>
            [NameInMap("MseRegistryType")]
            [Validation(Required=false)]
            public string MseRegistryType { get; set; }

            /// <summary>
            /// <para>The ID of the region where the namespace resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen:x*******</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region where the namespace resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>x******</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The AccessKey secret used in the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gOSgbgR2R*************</para>
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// <para>The tenant ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>401b7bc8-9441-4693-<b><b>-</b></b>********</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas_com***_****@<em><em><b><b>-</b></b></em>.</em>**</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
