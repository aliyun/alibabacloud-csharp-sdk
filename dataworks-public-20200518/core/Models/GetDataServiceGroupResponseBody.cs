// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the business process.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public GetDataServiceGroupResponseBodyGroup Group { get; set; }
        public class GetDataServiceGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>The ID of the API group that is associated with the business process in the API Gateway console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100abc</para>
            /// </summary>
            [NameInMap("ApiGatewayGroupId")]
            [Validation(Required=false)]
            public string ApiGatewayGroupId { get; set; }

            /// <summary>
            /// <para>The time when the business process was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-24T18:37:51+0800</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The user identifier (UID) of the creator of the business process. The value of this parameter may be empty for creators of some existing business processes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The description of the business process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The business process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_123abc</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the business process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The time when the business process was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-24T18:37:51+0800</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
