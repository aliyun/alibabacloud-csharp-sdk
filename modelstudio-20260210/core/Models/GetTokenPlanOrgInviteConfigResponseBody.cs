// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetTokenPlanOrgInviteConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data result of the current category statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTokenPlanOrgInviteConfigResponseBodyData Data { get; set; }
        public class GetTokenPlanOrgInviteConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The default organization role ID to assign. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM_ROLE_ORG_ADMIN</description></item>
            /// <item><description>SYSTEM_ROLE_ORG_MEMBER</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ORG_MEMBER</para>
            /// </summary>
            [NameInMap("DefaultRoleId")]
            [Validation(Required=false)]
            public string DefaultRoleId { get; set; }

            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org_123456789</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The default seat allocation strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HIGH_TO_LOW</description></item>
            /// <item><description>LOW_TO_HIGH </description></item>
            /// <item><description>NONE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NONE</para>
            /// </summary>
            [NameInMap("SeatAssignStrategy")]
            [Validation(Required=false)]
            public string SeatAssignStrategy { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
