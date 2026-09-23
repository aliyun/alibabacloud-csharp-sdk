// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The user group information.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public UpdateGroupResponseBodyGroup Group { get; set; }
        public class UpdateGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>The comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test team</para>
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>Format: RFC 3339 (UTC). Example: 2020-10-19T16:15:17Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-19T16:15:17Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The display name of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test-Team</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>740317625433843****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test-Team</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <para>Format: RFC 3339 (UTC). Example: 2020-10-20T03:44:27Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-20T03:44:27Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDA656E3-3CE9-4A03-A8A3-B42A0C3C3287</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
