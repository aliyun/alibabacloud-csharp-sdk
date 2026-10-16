// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The new type of the member. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceAccount: switches the specified cloud account to a resource account.</description></item>
        /// <item><description>CloudAccount: switches the specified resource account to a cloud account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Set either NewDisplayName or NewAccountType. You cannot set both of them at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceAccount</para>
        /// </summary>
        [NameInMap("NewAccountType")]
        [Validation(Required=false)]
        public string NewAccountType { get; set; }

        /// <summary>
        /// <para>The new name of the member.</para>
        /// <remarks>
        /// <para>Set either NewDisplayName or NewAccountType. You cannot set both of them at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

    }

}
