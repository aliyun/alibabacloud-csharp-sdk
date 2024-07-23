// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchMediaWorkflowRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description>A maximum of <b>100</b> entries can be returned on each page.</description></item>
        /// <item><description>Default value: <b>10</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The status of the media workflows that you want to query. You can specify multiple states. Separate multiple states with commas (,). Default value: <b>Inactive,Active,Deleted</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inactive</b>: Deactivated media workflows are queried.</description></item>
        /// <item><description><b>Active</b>: Activated media workflows are queried.</description></item>
        /// <item><description><b>Deleted</b>: Deleted media workflows are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Inactive,Active,Deleted</para>
        /// </summary>
        [NameInMap("StateList")]
        [Validation(Required=false)]
        public string StateList { get; set; }

    }

}
