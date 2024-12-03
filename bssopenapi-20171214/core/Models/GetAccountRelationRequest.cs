// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetAccountRelationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the financial relationship. Value returned by calling the AddAccountRelation operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. The ID is used to mark a request and troubleshoot a problem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>requestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
