// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class EnableOutputItemShareRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the output item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleOutputItemId</para>
        /// </summary>
        [NameInMap("outputItemId")]
        [Validation(Required=false)]
        public string OutputItemId { get; set; }

        /// <summary>
        /// <para>The name of the output item. This parameter must be used together with sessionId. If multiple output items have the same name, the request is rejected and you are prompted to use outputItemId instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly Review.pptx</para>
        /// </summary>
        [NameInMap("outputItemName")]
        [Validation(Required=false)]
        public string OutputItemName { get; set; }

        /// <summary>
        /// <para>The session ID used for exact filtering. The length is 1 to 128 characters. This parameter applies to common sessions, skill sessions, and the executionId of task executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The sharing scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Accessible to all users.</description></item>
        /// <item><description>SPECIFIED: Accessible only to specified users or user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("shareAccessType")]
        [Validation(Required=false)]
        public string ShareAccessType { get; set; }

        /// <summary>
        /// <para>The list of user group IDs within the specified scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;group-1&quot;]</para>
        /// </summary>
        [NameInMap("shareUserGroupIds")]
        [Validation(Required=false)]
        public List<string> ShareUserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of platform user IDs within the specified scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("shareUserIds")]
        [Validation(Required=false)]
        public List<long?> ShareUserIds { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
