// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ModifyForwardStrategyBindingItemsRequest : TeaModel {
        /// <summary>
        /// <para>The forwarding rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fs-849ac29396d9ea98</para>
        /// </summary>
        [NameInMap("ForwardId")]
        [Validation(Required=false)]
        public string ForwardId { get; set; }

        /// <summary>
        /// <para>The list of binding item IDs. Must be empty when MatchMode is <b>UserGroupAll</b> or <b>ApplicationAll</b>. Required for other values. Duplicates are not allowed in the list, and the specified objects must already exist.</para>
        /// </summary>
        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// <para>The policy matching target type. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: associates with all users.</description></item>
        /// <item><description><b>UserGroupNormal</b>: associates with specific user groups.</description></item>
        /// <item><description><b>ApplicationAll</b>: all private network applications.</description></item>
        /// <item><description><b>Application</b>: specific private network applications.</description></item>
        /// <item><description><b>Tag</b>: private network application tags.</description></item>
        /// </list>
        /// <para>When the value is <b>UserGroupAll</b> or <b>ApplicationAll</b>, ItemIds must be empty. When the value is <b>UserGroupNormal</b>, <b>Application</b>, or <b>Tag</b>, ItemIds is required.</para>
        /// <para>When ModifyType is not <b>Cover</b>, switching the matching target type is not allowed: <b>Application</b>, <b>Tag</b>, and <b>ApplicationAll</b> are mutually exclusive, and <b>UserGroupNormal</b> and <b>UserGroupAll</b> are mutually exclusive. If a binding item of a mutually exclusive type already exists on the same forwarding rule, the request is rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The modification method. Required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Append</b>: appends to existing binding items. ItemIds cannot contain objects that are already bound.</description></item>
        /// <item><description><b>Delete</b>: deletes specified binding items. All objects in ItemIds must be already bound.</description></item>
        /// <item><description><b>Cover</b>: overwrites binding items of the same category by clearing all existing binding items of the same category on the forwarding rule and then writing ItemIds. The same category refers to <b>ApplicationAll</b>, <b>Application</b>, and <b>Tag</b>, or <b>UserGroupAll</b> and <b>UserGroupNormal</b>.</description></item>
        /// </list>
        /// <para>When the value is <b>Append</b> or <b>Delete</b>, MatchMode cannot be <b>UserGroupAll</b> or <b>ApplicationAll</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

    }

}
