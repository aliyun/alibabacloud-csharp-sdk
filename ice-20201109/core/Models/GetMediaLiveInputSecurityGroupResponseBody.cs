// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaLiveInputSecurityGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security group information.</para>
        /// </summary>
        [NameInMap("SecurityGroup")]
        [Validation(Required=false)]
        public GetMediaLiveInputSecurityGroupResponseBodySecurityGroup SecurityGroup { get; set; }
        public class GetMediaLiveInputSecurityGroupResponseBodySecurityGroup : TeaModel {
            /// <summary>
            /// <para>The time when the security group was created. It follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:31:56Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The IDs of the inputs associated with the security group.</para>
            /// </summary>
            [NameInMap("InputIds")]
            [Validation(Required=false)]
            public List<string> InputIds { get; set; }

            /// <summary>
            /// <para>The name of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysg</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SEGK5KA6KYKAWQQH</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The security group rules.</para>
            /// </summary>
            [NameInMap("WhitelistRules")]
            [Validation(Required=false)]
            public List<string> WhitelistRules { get; set; }

        }

    }

}
