// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateAdvancedQueryHistoryRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The conditional statement.</para>
        /// <para>You can edit the conditional statement based on the <a href="https://help.aliyun.com/document_detail/2557373.html">SQL syntax for advanced event queries</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event.userIdentity.accessKeyId: *</para>
        /// </summary>
        [NameInMap("QuerySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the simple query mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SimpleQuery")]
        [Validation(Required=false)]
        public bool? SimpleQuery { get; set; }

    }

}
