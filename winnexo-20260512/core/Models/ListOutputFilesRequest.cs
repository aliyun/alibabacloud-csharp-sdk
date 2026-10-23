// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListOutputFilesRequest : TeaModel {
        /// <summary>
        /// <para>The business ID used for exact filtering. The length is 1 to 128 characters. This value is derived from the businessId of the file registration or associated workflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQ-20261012-001</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace. The length is 1 to 64 characters. This parameter is optional. If not specified, the personal outputs of the current user are queried. If specified, the real-time permissions of the workspace members and source resources are verified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123e4567-e89b-42d3-a456-426614174001</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The output item type. Valid values: ppt, html, document, picture, slides, video, audio, email, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>The keyword used to match the output title or detail name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly operations</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The name of the digital employee (operating object). Filters outputs by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business Analysis Assistant</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of items per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The session ID used for exact filtering. The length is 1 to 128 characters. This parameter applies to regular sessions, skill sessions, and the executionId of task executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session_123e4567-e89b-42d3-a456-426614174008</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to display only shared outputs and output details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("sharedOnly")]
        [Validation(Required=false)]
        public bool? SharedOnly { get; set; }

        /// <summary>
        /// <para>The tags used for exact filtering. All specified tags must be matched simultaneously. You can specify up to 20 tags. Each tag must be a non-empty string of 1 to 128 characters. Tags are derived from file registrations or the variables.tags of associated instances.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used. The identity and tenant permissions are determined by the gateway and backend authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
