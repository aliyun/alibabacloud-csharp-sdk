// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ResetDataServiceAppSecretRequest : TeaModel {
        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Reset Data Service Application Key</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public ResetDataServiceAppSecretRequestUpdateCommand UpdateCommand { get; set; }
        public class ResetDataServiceAppSecretRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>Application ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The new application key, which must be globally unique and is used when calling APIs.
            /// The length is 8 to 128 English characters, and can contain digits, underscores (_), and hyphens (-).
            /// Customization is supported only when using Alibaba Cloud API Gateway or the built-in gateway. This configuration is ignored when using a dedicated cloud gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000001</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The new application secret.
            /// If this parameter is left empty, the system automatically generates a new AppSecret value.
            /// The length is 8 to 127 English characters, and can contain digits, underscores (_), and hyphens (-).
            /// Customization is supported only when using Alibaba Cloud API Gateway or the built-in gateway. This configuration is ignored when using a dedicated cloud gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123456789</para>
            /// </summary>
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

        }

    }

}
