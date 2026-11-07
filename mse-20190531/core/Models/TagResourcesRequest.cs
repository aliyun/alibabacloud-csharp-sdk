// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <list type="bullet">
        /// <item><description><para><em>Registration and configuration center</em>: the instance ID.</para>
        /// </description></item>
        /// <item><description><para><em>Cloud-native gateway</em>: the unique ID of the gateway.</para>
        /// </description></item>
        /// <item><description><para><em>Microservice administration application</em>: the AppID of the microservice administration application. Note that this is not the LicenseKey.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The number in the parameter name specifies the index of the instance ID. For example:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>ResourceId.0</b> specifies the first instance ID.</para>
        /// </description></item>
        /// <item><description><para><b>ResourceId.1</b> specifies the second instance ID.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CLUSTER: a registration and configuration center.</para>
        /// </description></item>
        /// <item><description><para>GATEWAY: a cloud-native gateway.</para>
        /// </description></item>
        /// <item><description><para>GOVERNANCEAPPLICATION: a microservice administration application.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER、GATEWAY、GOVERNANCEAPPLICATION</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>A list of tags. You can specify up to 20 tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string. It can be up to 128 characters in length. The tag key cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c>. The tag key cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prd</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
