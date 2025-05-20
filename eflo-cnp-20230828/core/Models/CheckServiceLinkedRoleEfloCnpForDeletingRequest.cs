// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CheckServiceLinkedRoleEfloCnpForDeletingRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>345678901234</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The ID of the deletion task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-003</para>
        /// </summary>
        [NameInMap("DeletionTaskId")]
        [Validation(Required=false)]
        public string DeletionTaskId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role.</para>
        /// <para>The trusted entity of the RAM role is an Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/93691.html">Create a RAM role for a trusted Alibaba Cloud account</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</para>
        /// <para>Format: <c>acs:ram::&lt;account_id&gt;:role/&lt;role_name&gt;</c>.</para>
        /// <para>You can view the ARN in the RAM console or by calling operations. The following items describe the validity periods of storage addresses:</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the ARN in the RAM console, see <a href="https://help.aliyun.com/document_detail/39744.html">How do I find the ARN of the RAM role?</a></description></item>
        /// <item><description>For more information about how to view the ARN by calling operations, see <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> or <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>arn:aws:iam::345678901234:role/eflo-cnp-role</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SPIRegionId")]
        [Validation(Required=false)]
        public string SPIRegionId { get; set; }

        /// <summary>
        /// <para>The Service Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eflo-cnp</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
