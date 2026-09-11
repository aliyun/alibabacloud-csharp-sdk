// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class RetryLifecycleRetrieveJobRequest : TeaModel {
        /// <summary>
        /// <para>The data retrieval task ID.</para>
        /// <para><b>Scenarios</b></para>
        /// <para>Call this operation to retry a data retrieval task that has entered the <c>failed</c> state. Common causes for a task to enter the <c>failed</c> state include:</para>
        /// <list type="bullet">
        /// <item><description>A backend error occurred during data retrieval from the InfrequentAccess or Archive storage tier.</description></item>
        /// <item><description>The data retrieval request timed out.</description></item>
        /// <item><description>A temporary storage tier failure or network exception occurred.</description></item>
        /// </list>
        /// <para><b>Before you begin</b></para>
        /// <para>Before calling this operation, call <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-listlifecycleretrievejobs">ListLifecycleRetrieveJobs</a> to query the task list, confirm that the target task is in the <c>failed</c> state, and obtain the JobId of the task you want to retry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lrj-nfstest-ia-160****853-hshvw</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
