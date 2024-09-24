// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventQuaraFilesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the request source. Set the value to <b>sas</b>.</para>
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
        /// <para>The ID of the server group to which the server belongs. The quarantined file is located on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11472451</para>
        /// </summary>
        [NameInMap("GroupingId")]
        [Validation(Required=false)]
        public long? GroupingId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the quarantined file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a31337789f64d39b2219733ec99f9af7</para>
        /// </summary>
        [NameInMap("QuaraTag")]
        [Validation(Required=false)]
        public string QuaraTag { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59.82.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The status of the quarantined file that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>quaraFailed</b>: The file fails to be quarantined.</description></item>
        /// <item><description><b>quaraDone</b>: The file is quarantined.</description></item>
        /// <item><description><b>quaraing</b>: The file is being quarantined.</description></item>
        /// <item><description><b>rollbackFailed</b>: The system fails to cancel quarantining the file.</description></item>
        /// <item><description><b>rollbackDone</b>: The system cancelled quarantining the file.</description></item>
        /// <item><description><b>rollbacking</b>: The system is cancelling quarantining the file.</description></item>
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
