// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class UpdateResourceShareResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2860A3A4-D8C1-4EF4-954E-84A3945E26E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the resource share.</para>
        /// </summary>
        [NameInMap("ResourceShare")]
        [Validation(Required=false)]
        public UpdateResourceShareResponseBodyResourceShare ResourceShare { get; set; }
        public class UpdateResourceShareResponseBodyResourceShare : TeaModel {
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
            /// <para>2020-12-03T08:02:22.413Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rs-qSkW1HBY****</para>
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// <para>The name of the resource share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new</para>
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

            /// <summary>
            /// <para>The time when the resource share was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-04T08:55:25.382Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
