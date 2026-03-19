// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DisableBackupLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>findValidDBSJob error</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Indicates whether this change triggers a precheck. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: A precheck is triggered. You must manually call the <a href="https://help.aliyun.com/document_detail/2869816.html">StartBackupPlan</a> operation to start the backup plan.</para>
        /// </description></item>
        /// <item><description><para>false: No precheck is triggered.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedPrecheck")]
        [Validation(Required=false)]
        public bool? NeedPrecheck { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6E068C3-25BC-455A-85FE-45F0B22ECB1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
