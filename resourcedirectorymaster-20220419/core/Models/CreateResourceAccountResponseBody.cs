// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class CreateResourceAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the member.</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public CreateResourceAccountResponseBodyAccount Account { get; set; }
        public class CreateResourceAccountResponseBodyAccount : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112730938585****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice@rd-3g****.aliyunid.com</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The display name of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dev</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-r23M55****</para>
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
            /// <para>2020-12-31T03:37:39.456Z</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// <para>The time when the member was modified. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-31T03:37:39.456Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-3G****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The status of the member. The value CreateSuccess indicates that the member is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the member. The value ResourceAccount indicates that the member is a resource account.</para>
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
        /// <para>B356A415-D860-43E5-865A-E2193D62BBD6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
