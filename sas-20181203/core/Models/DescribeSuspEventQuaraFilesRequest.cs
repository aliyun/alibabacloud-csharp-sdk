// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventQuaraFilesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the file list to view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The identifier of the request source. Set the value to <b>sas</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10541428</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the server group where the quarantined file is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11472451</para>
        /// </summary>
        [NameInMap("GroupingId")]
        [Validation(Required=false)]
        public long? GroupingId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the quarantined file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a31337789f64d39b2219733ec99f9af7</para>
        /// </summary>
        [NameInMap("QuaraTag")]
        [Validation(Required=false)]
        public string QuaraTag { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59.82.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The status of the quarantined files to query. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>quaraFailed</b>: Quarantine failed.</description></item>
        /// <item><description><b>quaraDone</b>: Quarantine succeeded.</description></item>
        /// <item><description><b>quaraing</b>: Quarantine in progress.</description></item>
        /// <item><description><b>rollbackFailed</b>: Quarantine rollback failed.</description></item>
        /// <item><description><b>rollbackDone</b>: Quarantine rollback succeeded.</description></item>
        /// <item><description><b>rollbacking</b>: Quarantine rollback in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>quaraDone</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
