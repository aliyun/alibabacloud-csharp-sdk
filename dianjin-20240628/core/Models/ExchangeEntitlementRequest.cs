// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class ExchangeEntitlementRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_user_id_001</para>
        /// </summary>
        [NameInMap("externalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a1b2c3d4e5f6...</para>
        /// </summary>
        [NameInMap("keyHash")]
        [Validation(Required=false)]
        public string KeyHash { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req_20240101_001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
