// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCloudAccountRequest : TeaModel {
        /// <summary>
        /// <para>A client token that ensures the idempotence of the request. The client must generate a unique token for each request. The token must consist of only ASCII characters and be no more than 64 characters in length. For more information, see <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The external unique identifier of the cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("CloudAccountExternalId")]
        [Validation(Required=false)]
        public string CloudAccountExternalId { get; set; }

        /// <summary>
        /// <para>The name of the cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_accout_xxxx</para>
        /// </summary>
        [NameInMap("CloudAccountName")]
        [Validation(Required=false)]
        public string CloudAccountName { get; set; }

        /// <summary>
        /// <para>The name of the identity provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas-eiam-oidc-provider</para>
        /// </summary>
        [NameInMap("CloudAccountProviderName")]
        [Validation(Required=false)]
        public string CloudAccountProviderName { get; set; }

        /// <summary>
        /// <para>The site of the cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>global: international site</para>
        /// </description></item>
        /// <item><description><para>china_mainland: China mainland site</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>china_mainland</para>
        /// </summary>
        [NameInMap("CloudAccountSite")]
        [Validation(Required=false)]
        public string CloudAccountSite { get; set; }

        /// <summary>
        /// <para>The type of the cloud account. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>alibaba_cloud: Alibaba Cloud</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba_cloud(Alibaba Cloud)</para>
        /// </summary>
        [NameInMap("CloudAccountVendorType")]
        [Validation(Required=false)]
        public string CloudAccountVendorType { get; set; }

        /// <summary>
        /// <para>The description of the cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_accout_description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
