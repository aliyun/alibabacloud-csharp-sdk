// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCloudAccountRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>云账号唯一标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("CloudAccountExternalId")]
        [Validation(Required=false)]
        public string CloudAccountExternalId { get; set; }

        /// <summary>
        /// <para>云账号名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_accout_xxxx</para>
        /// </summary>
        [NameInMap("CloudAccountName")]
        [Validation(Required=false)]
        public string CloudAccountName { get; set; }

        /// <summary>
        /// <para>云账号提供商名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas-eiam-oidc-provider</para>
        /// </summary>
        [NameInMap("CloudAccountProviderName")]
        [Validation(Required=false)]
        public string CloudAccountProviderName { get; set; }

        /// <summary>
        /// <para>云账号类型</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CloudAccountVendorType")]
        [Validation(Required=false)]
        public string CloudAccountVendorType { get; set; }

        /// <summary>
        /// <para>云账号描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_accout_description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
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
