// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeSandboxBackupSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data. The following parameters are contained:</para>
        /// <list type="bullet">
        /// <item><description><b>backupSetTime</b>: the point in time when the snapshot was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</description></item>
        /// <item><description><b>backupSetId</b>: the ID of the backup set.</description></item>
        /// <item><description><b>backupSetType</b>: the type of the snapshot. A value of <b>Full</b> indicates that the snapshot is a full backup snapshot. A value of <b>Inc</b> indicates that the snapshot is an incremental backup snapshot.</description></item>
        /// <item><description><b>backupPlanId</b>: the ID of the backup schedule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Data&quot;: {     &quot;number&quot;: 2,     &quot;size&quot;: 2,     &quot;content&quot;: [       {         &quot;backupSetTime&quot;: &quot;2021-08-28T23:12:31Z&quot;,         &quot;backupSetId&quot;: &quot;Inc_1hxxxx8xxxxxa_20210801064200_mysql-bin.000134&quot;,         &quot;backupSetType&quot;: &quot;Inc&quot;,         &quot;backupPlanId&quot;: &quot;1hxxxx8xxxxxa&quot;       },       {         &quot;backupSetTime&quot;: &quot;2021-08-28T22:42:28Z&quot;,         &quot;backupSetId&quot;: &quot;1hxxxx8xxxxxa_20210829064228&quot;,         &quot;backupSetType&quot;: &quot;FULL&quot;,         &quot;backupPlanId&quot;: &quot;1hxxxx8xxxxxa&quot;       }     ],     &quot;totalElements&quot;: 2   },</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F1888AC-1138-4995-B9FE-D2734F61C058</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
