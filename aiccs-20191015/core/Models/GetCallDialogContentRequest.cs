// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetCallDialogContentRequest : TeaModel {
        /// <summary>
        /// <para>The outbound call date, in yyyy-MM-dd format. You can only query data from the last 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-06</para>
        /// </summary>
        [NameInMap("CallDate")]
        [Validation(Required=false)]
        public string CallDate { get; set; }

        /// <summary>
        /// <para>The unique identifier for a call.</para>
        /// <remarks>
        /// <para>The LlmSmartCall API returns this ID in the CallId parameter of its response.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456^123478</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
