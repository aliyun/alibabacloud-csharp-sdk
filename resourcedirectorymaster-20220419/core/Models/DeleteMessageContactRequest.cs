// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DeleteMessageContactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-qL4HqKONzOM7****</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the contact for members. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): retains the contact for members. In this case, the contact can still receive messages for the members.</description></item>
        /// <item><description>false: does not retain the contact for members. In this case, the contact can no longer receive messages for the members. If you set this parameter to false, the response is asynchronously returned. You can call <a href="~~GetMessageContactDeletionStatus~~">GetMessageContactDeletionStatus</a> to obtain the deletion result.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RetainContactInMembers")]
        [Validation(Required=false)]
        public bool? RetainContactInMembers { get; set; }

    }

}
