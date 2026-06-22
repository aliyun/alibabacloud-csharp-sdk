// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectEventRequest : TeaModel {
        [NameInMap("AnalyzeResult")]
        [Validation(Required=false)]
        public string AnalyzeResult { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The unique identifier of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a212417e65c26ff133cfff28f6c****</para>
        /// </summary>
        [NameInMap("HashKey")]
        [Validation(Required=false)]
        public string HashKey { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paged query. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The parent process path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/bin/bash</para>
        /// </summary>
        [NameInMap("ParentProcessPath")]
        [Validation(Required=false)]
        public string ParentProcessPath { get; set; }

        /// <summary>
        /// <para>The process path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("ProcessPath")]
        [Validation(Required=false)]
        public string ProcessPath { get; set; }

        /// <summary>
        /// <para>The filter condition. You can filter by instance name or IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.167.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Unhandled.</description></item>
        /// <item><description><b>2</b>: Blocked.</description></item>
        /// <item><description><b>3</b>: Ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18b7336e-d469-473b-af83-8e5420f9****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
