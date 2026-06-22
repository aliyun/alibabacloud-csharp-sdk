// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectClientEventRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert notification levels.</para>
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public List<int?> AlertLevels { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1650470399999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of excluded event IDs.</para>
        /// </summary>
        [NameInMap("ExcludeIdList")]
        [Validation(Required=false)]
        public List<long?> ExcludeIdList { get; set; }

        /// <summary>
        /// <para>The file path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/pam****</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The list of event IDs.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

        /// <summary>
        /// <para>The ID of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1fu4aqltf1huhc****</para>
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
        /// <para>The new status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Handled.</description></item>
        /// <item><description><b>2</b>: Whitelisted.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NewStatus")]
        [Validation(Required=false)]
        public int? NewStatus { get; set; }

        /// <summary>
        /// <para>The type of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READ</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The process path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/1111/****</para>
        /// </summary>
        [NameInMap("ProcPath")]
        [Validation(Required=false)]
        public string ProcPath { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public List<string> Remark { get; set; }

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
        /// <para>Specifies whether to select all.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectAll")]
        [Validation(Required=false)]
        public bool? SelectAll { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649260800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Handled.</description></item>
        /// <item><description><b>2</b>: Whitelisted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The UUID of the protected server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae1527a9-2308-46ab-b10a-48ae7ff7****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
