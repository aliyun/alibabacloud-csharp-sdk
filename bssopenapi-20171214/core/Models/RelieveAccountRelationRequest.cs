// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class RelieveAccountRelationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used as the member. You must set the RelationId parameter or all of the ParentUserId, ChildUserId, and RelationType parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1512996702208737</para>
        /// </summary>
        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used as the management account. You must set the RelationId parameter or all of the ParentUserId, ChildUserId, and RelationType parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1738376485192612</para>
        /// </summary>
        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public long? ParentUserId { get; set; }

        /// <summary>
        /// <para>The ID of the financial relationship between the management account and the member. You must set the RelationId parameter or all of the ParentUserId, ChildUserId, and RelationType parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RelationId</para>
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        /// <summary>
        /// <para>The type of the financial relationship. Set the value to enterprise_group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise_group</para>
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. The ID is used to mark a request and troubleshoot a problem.</para>
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
