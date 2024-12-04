// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PullLogsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTQ0NzMyOTQwMTEwMjEzMDkwNA</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MTU1NzA1NzQwMTEwMjEzMDkwCg</para>
        /// </summary>
        [NameInMap("end_cursor")]
        [Validation(Required=false)]
        public string EndCursor { get; set; }

        /// <summary>
        /// <para>The SPL statement that is used to filter data. For more information, see <a href="https://help.aliyun.com/document_detail/2536530.html">SPL instructions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| where userId=\&quot;123\&quot;</description></item>
        /// </list>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
