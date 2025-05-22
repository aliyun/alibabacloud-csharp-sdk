// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListAITasksRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of data entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>U12WEI6Ro2ol3wA54rBNS3Cltv2VJyA+7hP4GqbIOhmWU5mWU9ZE3cXLgDaH4KSMRfIYcIVrvtHaAzCoyfo7VQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the AI task. You can filter AI tasks by task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-asasas*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the AI task. You can filter AI tasks by task type.</para>
        /// <list type="bullet">
        /// <item><description>GenerateTemplate: The AI task is used to generate a template.</description></item>
        /// <item><description>FixTemplate: The AI task is used to fix a template.</description></item>
        /// </list>
        /// <para>If you leave this parameter empty, all task types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GenerateTemplate</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
