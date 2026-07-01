// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class FetchSqlPreviewResultsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-00000022****</para>
        /// </summary>
        [NameInMap("queryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-test</para>
        /// </summary>
        [NameInMap("sessionClusterName")]
        [Validation(Required=false)]
        public string SessionClusterName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-00000033****</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
