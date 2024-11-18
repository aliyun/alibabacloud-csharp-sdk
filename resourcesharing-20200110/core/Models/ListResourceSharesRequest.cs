// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceSharesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return for a single request.</para>
        /// <para>Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The <c>token</c> that is used to initiate the next request. If the response of the current request is truncated, you can use the token to initiate another request and obtain the remaining records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the permission. For more information, see <a href="https://help.aliyun.com/document_detail/465474.html">Permission library</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunRSDefaultPermissionVSwitch</para>
        /// </summary>
        [NameInMap("PermissionName")]
        [Validation(Required=false)]
        public string PermissionName { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The owner of the resource shares. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Self: the current account</description></item>
        /// <item><description>OtherAccounts: an account other than the current account</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Self</para>
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public string ResourceOwner { get; set; }

        /// <summary>
        /// <para>The ID of a resource share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rs-PqysnzIj****</para>
        /// </summary>
        [NameInMap("ResourceShareIds")]
        [Validation(Required=false)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// <para>The name of the resource share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

        /// <summary>
        /// <para>The status of the resource share. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: The resource share is enabled.</description></item>
        /// <item><description>Pending: The resource share is associated with one or more resource sharing invitations that are waiting for confirmation.</description></item>
        /// <item><description>Deleting: The resource share is being deleted.</description></item>
        /// <item><description>Deleted: The resource share is deleted.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The system deletes the records of resource shares in the Deleted state within 48 hours to 96 hours after you delete the resource shares.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("ResourceShareStatus")]
        [Validation(Required=false)]
        public string ResourceShareStatus { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListResourceSharesRequestTag> Tag { get; set; }
        public class ListResourceSharesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
