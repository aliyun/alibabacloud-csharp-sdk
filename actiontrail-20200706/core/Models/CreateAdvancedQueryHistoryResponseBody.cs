// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateAdvancedQueryHistoryResponseBody : TeaModel {
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public string DryRunResult { get; set; }

        /// <summary>
        /// <para>The ID of the advanced event query record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query-uIkIvLiVSuCKqg0yoa****</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>The advanced event query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event.userIdentity.accessKeyId: *</para>
        /// </summary>
        [NameInMap("QuerySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0227506-AA8C-5998-8A62-74769106****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the simple query mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SimpleQuery")]
        [Validation(Required=false)]
        public bool? SimpleQuery { get; set; }

    }

}
