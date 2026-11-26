// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The group information.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public CreateGroupResponseBodyGroup Group { get; set; }
        public class CreateGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>The time when the group was created. The time is in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01T02:38:27Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a group.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-00jqzghi2n3o5hkh****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: The group is manually created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("ProvisionType")]
            [Validation(Required=false)]
            public string ProvisionType { get; set; }

            /// <summary>
            /// <para>The time when the group was updated. The time is in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01T02:38:27Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20E9650E-EC23-593E-933F-EA0D280D040C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
