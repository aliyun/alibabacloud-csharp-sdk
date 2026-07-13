// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListProtectionPolicyApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The application status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED</para>
        /// </summary>
        [NameInMap("ApplyStatus")]
        [Validation(Required=false)]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return in a single page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. The response returns a <c>NextToken</c> value only when more results are available. To retrieve the next page, include the <c>NextToken</c> from the previous response in your request. If the response does not include a <c>NextToken</c> value, all results have been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cae**********699</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The sub-protection policy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_AUTO_SNAPSHOT_POLICY</para>
        /// </summary>
        [NameInMap("SubProtectionPolicyType")]
        [Validation(Required=false)]
        public string SubProtectionPolicyType { get; set; }

        /// <summary>
        /// <para>The task ID. You can call the DescribeTasks operation to query task IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-0004d9ctt1ii********</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
