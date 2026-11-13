// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the business flow.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public GetDataServiceGroupResponseBodyGroup Group { get; set; }
        public class GetDataServiceGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the API Gateway group that is associated with the business flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100abc</para>
            /// </summary>
            [NameInMap("ApiGatewayGroupId")]
            [Validation(Required=false)]
            public string ApiGatewayGroupId { get; set; }

            /// <summary>
            /// <para>The gateway version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: API Gateway.</description></item>
            /// <item><description>2: Cloud-native API Gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApigwVersion")]
            [Validation(Required=false)]
            public int? ApigwVersion { get; set; }

            /// <summary>
            /// <para>The security authentication method for the cloud-native API Gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: No authentication.</description></item>
            /// <item><description>2: ApiKey.</description></item>
            /// <item><description>3: JWT.</description></item>
            /// <item><description>4: HMAC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CloudNativeApigwGroupId")]
            [Validation(Required=false)]
            public string CloudNativeApigwGroupId { get; set; }

            /// <summary>
            /// <para>The creation time of the business flow.</para>
            /// <para>The format is <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ssZ</c>. Example: <c>2020-09-24T18:37:51+0800</c>. In this example, the time zone offset is <c>+0800</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-24T18:37:51+0800</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The UID of the creator. The creator UID may be empty for some historical business flows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The description of the business flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business flow description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the business flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_123abc</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the business flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business flow name</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// <para>The format is <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ssZ</c>. Example: <c>2020-09-24T18:37:51+0800</c>. In this example, the time zone offset is <c>+0800</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-24T18:37:51+0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10002</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10003</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
