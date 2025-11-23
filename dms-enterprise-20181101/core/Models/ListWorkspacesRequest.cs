// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkspacesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the current user has joined the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AlreadyJoined")]
        [Validation(Required=false)]
        public bool? AlreadyJoined { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the bucket is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The search keyword. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>poc_test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The service account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ServiceAccountId")]
        [Validation(Required=false)]
        public long? ServiceAccountId { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// <remarks>
        /// <para>This parameter cannot be used as a filter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp10wnlcmor****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
