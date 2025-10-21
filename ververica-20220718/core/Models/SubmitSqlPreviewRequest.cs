// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SubmitSqlPreviewRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public SqlStatementWithContext Body { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-session</para>
        /// </summary>
        [NameInMap("sessionClusterName")]
        [Validation(Required=false)]
        public string SessionClusterName { get; set; }

    }

}
