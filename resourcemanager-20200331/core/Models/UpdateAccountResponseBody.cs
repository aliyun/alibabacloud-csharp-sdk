// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the member.</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public UpdateAccountResponseBodyAccount Account { get; set; }
        public class UpdateAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that corresponds to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12323344****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account that corresponds to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:ecs-manager@aliyun.com">ecs-manager@aliyun.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The display name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-bVaRIG****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The way in which the member joins the resource directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>invited: The member is invited to join the resource directory.</description></item>
            /// <item><description>created: The member is directly created in the resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            /// <summary>
            /// <para>The time when the member joined the resource directory. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// <para>The time when the member was modified. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-k3****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The status of the member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateSuccess: The member is created.</description></item>
            /// <item><description>InviteSuccess: The member accepts the invitation.</description></item>
            /// <item><description>Removed: The member is removed.</description></item>
            /// <item><description>SwitchSuccess: The type of the member is switched.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CreateSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CloudAccount: cloud account</description></item>
            /// <item><description>ResourceAccount: resource account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceAccount</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B34724D-54B0-4A51-B34D-4512372FE1BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
