// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListMessageContactsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-qL4HqKONzOM7****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>The ID of the object to which the contact is bound. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ID of the resource directory</description></item>
        /// <item><description>ID of the folder</description></item>
        /// <item><description>ID of the member</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fd-ZDNPiT****</para>
        /// </summary>
        [NameInMap("Member")]
        [Validation(Required=false)]
        public string Member { get; set; }

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

    }

}
