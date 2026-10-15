// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class RelieveAccountRelationRequest : TeaModel {
        /// <summary>
        /// <para>The UID of the RAM user. You must specify either the RelationId parameter, or the ParentUserId, ChildUserId, and RelationType parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1512996702208737</para>
        /// </summary>
        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account. You must specify either the RelationId parameter, or the ParentUserId, ChildUserId, and RelationType parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1738376485192612</para>
        /// </summary>
        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public long? ParentUserId { get; set; }

        /// <summary>
        /// <para>The ID of the account association. You must specify either the RelationId parameter, or the ParentUserId, ChildUserId, and RelationType parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RelationId</para>
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        /// <summary>
        /// <para>The relationship type. Only enterprise_group is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise_group</para>
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. This ID is used to troubleshoot issues.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_id</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
