// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteRecursionRecordRequest : TeaModel {
        /// <summary>
        /// <para>The client token that ensures the idempotence of the request. The client generates this value. It must be unique across requests. The value can be up to 64 ASCII characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the DNS record. This is the unique identifier for the record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17432432424</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

    }

}
