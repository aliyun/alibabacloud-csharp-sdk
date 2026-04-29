// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryRecallManagementTableRecordsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;1001&quot;,&quot;1002&quot;]</para>
        /// </summary>
        [NameInMap("PrimaryKeys")]
        [Validation(Required=false)]
        public byte[] PrimaryKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecallManagementTableVersionId")]
        [Validation(Required=false)]
        public string RecallManagementTableVersionId { get; set; }

    }

}
