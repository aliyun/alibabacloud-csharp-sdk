// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectEventStatusRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert notification levels.</para>
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public List<int?> AlertLevels { get; set; }

        /// <summary>
        /// <para>The end timestamp of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649040221</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of event IDs.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public List<long?> Id { get; set; }

        /// <summary>
        /// <para>The ID of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g6wxdwps7s9dz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.27.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The internal IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.26.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The type of operation performed on the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DELETE</b>: Deletes a file.</description></item>
        /// <item><description><b>WRITE</b>: Writes to a file.</description></item>
        /// <item><description><b>READ</b>: Reads a file.</description></item>
        /// <item><description><b>RENAME</b>: Renames a file.</description></item>
        /// <item><description><b>CHOWN</b>: Changes the file owner and associated file group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>READ</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tetsRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Specifies whether to select all items across pages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Selected.</description></item>
        /// <item><description><b>false</b>: Not selected.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SelectAllAcrossPages")]
        [Validation(Required=false)]
        public bool? SelectAllAcrossPages { get; set; }

        /// <summary>
        /// <para>The start timestamp of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1680919232000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The event handling status.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled</description></item>
        /// <item><description><b>1</b>: Manually handled</description></item>
        /// <item><description><b>2</b>: Added to whitelist</description></item>
        /// <item><description><b>3</b>: Ignored</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eb2c782e-64f2-4590-a86c-d90164df****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
