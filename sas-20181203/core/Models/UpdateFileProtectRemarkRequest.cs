// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectRemarkRequest : TeaModel {
        /// <summary>
        /// <para>Alert notification level list.</para>
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public List<int?> AlertLevels { get; set; }

        /// <summary>
        /// <para>End time timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649040221</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1764</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Event ID list.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

        /// <summary>
        /// <para>Asset instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g6wxdwps7s9dz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Asset instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Public IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.132.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>Private IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.26.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>File operation type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>DELETE</b>: File deletion operation.</description></item>
        /// <item><description><b>WRITE</b>: File write operation.</description></item>
        /// <item><description><b>READ</b>: File read operation.</description></item>
        /// <item><description><b>RENAME</b>: File rename operation.</description></item>
        /// <item><description><b>CHOWN</b>: Set file owner and associated group operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>READ</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public List<string> Remark { get; set; }

        /// <summary>
        /// <para>Rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-rule-1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Cross-page select all indicator. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectAllAcrossPages")]
        [Validation(Required=false)]
        public bool? SelectAllAcrossPages { get; set; }

        /// <summary>
        /// <para>Start time timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651290987000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Server UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d55af3c-35f3-4d4d-8ccc-8c5443b0****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
