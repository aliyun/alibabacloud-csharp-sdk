// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddDataServiceProjectMemberRequest : TeaModel {
        /// <summary>
        /// <para>The command to add project members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddCommand")]
        [Validation(Required=false)]
        public AddDataServiceProjectMemberRequestAddCommand AddCommand { get; set; }
        public class AddDataServiceProjectMemberRequestAddCommand : TeaModel {
            /// <summary>
            /// <para>The list of project members to add.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProjectMemberList")]
            [Validation(Required=false)]
            public List<AddDataServiceProjectMemberRequestAddCommandProjectMemberList> ProjectMemberList { get; set; }
            public class AddDataServiceProjectMemberRequestAddCommandProjectMemberList : TeaModel {
                /// <summary>
                /// <para>The username of the user.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:xx@aliyuncs.com">xx@aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The role of the user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>2: development user</description></item>
                /// <item><description>3: application member</description></item>
                /// <item><description>4: service project administrator</description></item>
                /// <item><description>5: O&amp;M user.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public int? Role { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The data service project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102102</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

    }

}
