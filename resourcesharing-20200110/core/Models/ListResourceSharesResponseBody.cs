// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListResourceSharesResponseBody : TeaModel {
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F23CFB6-A721-4E90-AC1E-0E30FA8B45DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the resource shares.</para>
        /// </summary>
        [NameInMap("ResourceShares")]
        [Validation(Required=false)]
        public List<ListResourceSharesResponseBodyResourceShares> ResourceShares { get; set; }
        public class ListResourceSharesResponseBodyResourceShares : TeaModel {
            /// <summary>
            /// <para>Indicates whether resources in the resource share can be shared with accounts outside the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: Resources in the resource share can be shared only with accounts in the resource directory.</description></item>
            /// <item><description>true: Resources in the resource share can be shared with both accounts in the resource directory and accounts outside the resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowExternalTargets")]
            [Validation(Required=false)]
            public bool? AllowExternalTargets { get; set; }

            /// <summary>
            /// <para>The time when the resource share was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-03T02:20:31.292Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rs-PqysnzIj****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

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
            /// <para>The owner of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151266687691****</para>
            /// </summary>
            [NameInMap("ResourceShareOwner")]
            [Validation(Required=false)]
            public string ResourceShareOwner { get; set; }

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

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListResourceSharesResponseBodyResourceSharesTags> Tags { get; set; }
            public class ListResourceSharesResponseBodyResourceSharesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the resource share was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-03T08:01:43.638Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
