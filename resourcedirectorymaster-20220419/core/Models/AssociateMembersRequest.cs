// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class AssociateMembersRequest : TeaModel {
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
        /// <para>The IDs of objects to which you want to bind the contact.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<string> Members { get; set; }

    }

}
