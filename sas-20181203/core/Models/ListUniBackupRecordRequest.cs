// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUniBackupRecordRequest : TeaModel {
        /// <summary>
        /// <para>The region where the anti-ransomware backup service is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("BackupRegionId")]
        [Validation(Required=false)]
        public string BackupRegionId { get; set; }

        /// <summary>
        /// <para>When performing a paginated query, set the page number for the current page. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The identification information of the server protected by the anti-ransomware policy. You can enter the IP address or instance ID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries to display per page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Backup status. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>completed</b>: Success</description></item>
        /// <item><description><b>error</b>: Failure</description></item>
        /// <item><description><b>canceled</b>: Closed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
