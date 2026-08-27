// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetInstanceAsyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AgentTeams instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page size. Default value: <c>100</c>. Valid values: <c>1</c> to <c>100</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. Do not specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The task status filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PAUSED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task code. If not specified, all asynchronous tasks are queried. You can pass in a <c>TaskCode</c> to filter results. To query multiple task types, submit separate requests.</para>
        /// <para>Currently supported <c>taskCode</c> values include: <c>CreateInstance</c>, <c>RenewInstance</c>, <c>UpdateInstance</c>, <c>ReleaseInstance</c>, <c>ConfigureNatGateway</c>, <c>UpgradeInstance</c>, <c>CreateWorkerEndpoint</c>, and <c>DeleteWorkerEndpoint</c>.</para>
        /// <para>Legacy task codes such as <c>LIFECYCLE_MAGIC_PAY_ORDER_CALLBACK_CREATE</c> are supported for backward compatibility, but <c>CreateInstance</c> is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIFECYCLE_MAGIC_PAY_ORDER_CALLBACK_CREATE</para>
        /// </summary>
        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

    }

}
