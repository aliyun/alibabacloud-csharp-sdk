// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateTokenPlanKeyRequest : TeaModel {
        /// <summary>
        /// <para>The account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc_123456789</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The account ID of the caller that identifies the initiator of this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc_123456789</para>
        /// </summary>
        [NameInMap("CallerUacAccountId")]
        [Validation(Required=false)]
        public string CallerUacAccountId { get; set; }

        /// <summary>
        /// <para>The description of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APIKEY描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The product namespace ID. For the TokenPlan product, this field is fixed to namespace-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace-1</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws_123456789</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
