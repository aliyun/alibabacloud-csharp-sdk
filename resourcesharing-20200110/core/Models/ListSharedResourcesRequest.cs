// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedResourcesRequest : TeaModel {
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

        [NameInMap("ResourceArns")]
        [Validation(Required=false)]
        public List<string> ResourceArns { get; set; }

        /// <summary>
        /// <para>The ID of a shared resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1upw03qyz8n7us9****</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The owner of the resource shares. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Self: your account. If you set the value to Self, the resources you share with other accounts are queried.</description></item>
        /// <item><description>OtherAccounts: another account. If you set the value to OtherAccounts, the resources other accounts share with you are queried.</description></item>
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
        /// <para>rs-6GRmdD3X****</para>
        /// </summary>
        [NameInMap("ResourceShareIds")]
        [Validation(Required=false)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// <para>The type of the shared resources.</para>
        /// <para>For more information about the types of resources that can be shared, see <a href="https://help.aliyun.com/document_detail/450526.html">Services that work with Resource Sharing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VSwitch</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the principal or resource owner.</para>
        /// <list type="bullet">
        /// <item><description>If the value of <c>ResourceOwner</c> is <c>Self</c>, set this parameter to the ID of a principal.</description></item>
        /// <item><description>If the value of <c>ResourceOwner</c> is <c>OtherAccounts</c>, set this parameter to the ID of a resource owner.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172050525300****</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
