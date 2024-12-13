// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the group.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public CreateGroupResponseBodyGroup Group { get; set; }
        public class CreateGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>The time when the group was created.</para>
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
            /// <para>The type of the group. The value is fixed as Manual, which indicates that the group is manually created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("ProvisionType")]
            [Validation(Required=false)]
            public string ProvisionType { get; set; }

            /// <summary>
            /// <para>The time when the information about the group was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01T02:38:27Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20E9650E-EC23-593E-933F-EA0D280D040C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
