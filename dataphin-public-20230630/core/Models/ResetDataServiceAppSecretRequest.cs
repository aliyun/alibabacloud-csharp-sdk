// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ResetDataServiceAppSecretRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The update command to reset the application key of a data service.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public ResetDataServiceAppSecretRequestUpdateCommand UpdateCommand { get; set; }
        public class ResetDataServiceAppSecretRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>The new application key. The key must be globally unique and is used when you call API operations. The key must be 8 to 128 characters in length, and can contain digits, underscores (_), and hyphens (-). You can customize this parameter only when you use Alibaba Cloud API Gateway or the built-in gateway. If you use Apsara Stack Gateway, this parameter is ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000001</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The new application secret. If you leave this parameter empty, the system automatically generates a new AppSecret value. The secret must be 8 to 127 characters in length, and can contain digits, underscores (_), and hyphens (-). You can customize this parameter only when you use Alibaba Cloud API Gateway or the built-in gateway. If you use Apsara Stack Gateway, this parameter is ignored.</para>
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
