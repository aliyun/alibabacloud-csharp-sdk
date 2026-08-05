// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListRtcMPUTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para>The application ID consists of uppercase and lowercase letters, digits, underscores, and hyphens (-), with a maximum of 64 characters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <remarks>
        /// <para>If you do not specify a task ID, you must specify the PageSize and PageNo parameters. In this case, the paged query results of all stream mixing and relaying tasks under the specified application ID are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: 1 to 100.</para>
        /// <remarks>
        /// <para>If you do not specify a task ID, you must specify the PageSize and PageNo parameters. In this case, the paged query results of all stream mixing and relaying tasks under the specified application ID are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The task ID consists of uppercase and lowercase letters, digits, underscores, and hyphens (-), with a maximum of 55 characters.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you specify a task ID, the query is performed based on the task ID first, and the result contains the parameter details of the stream mixing and relaying task with the specified task ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yourTaskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
