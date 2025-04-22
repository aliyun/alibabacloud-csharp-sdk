// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AuditLogExportRequest : TeaModel {
        /// <summary>
        /// <para>The name of the exported file. The name can be up to 1,024 characters in length. The default name suffix is log.csv.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-log.csv</para>
        /// </summary>
        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The export language. Default value: zh-CN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en_US: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The sort order based on the operation time. If you leave this parameter empty, the value acted_at DESC is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>acted_at DESC: sorts the entries by operation time in descending order</description></item>
        /// <item><description>acted_at ASC: sorts the entries by operation time in ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acted_at DESC</para>
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The fields used for query. You can specify one or more of the following fields:</para>
        /// <list type="bullet">
        /// <item><description>drive_id (space ID, in the form of a string)</description></item>
        /// <item><description>actor_id (operator ID, in the form of a string)</description></item>
        /// <item><description>acted_at (operation time, in the yyyy-MM-ddTHH:mm:ssZ format in UTC, for example, 2006-01-02T00:00:00)</description></item>
        /// <item><description>action_type (operation type, in the form of a string)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acted_at &gt; \&quot;2025-03-10T16:00:00\&quot; and acted_at &lt; \&quot;2025-03-17T15:59:59\&quot;</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
