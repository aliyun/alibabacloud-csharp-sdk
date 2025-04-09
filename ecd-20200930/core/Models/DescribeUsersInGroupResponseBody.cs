// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUsersInGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorized users.</para>
        /// </summary>
        [NameInMap("EndUsers")]
        [Validation(Required=false)]
        public List<DescribeUsersInGroupResponseBodyEndUsers> EndUsers { get; set; }
        public class DescribeUsersInGroupResponseBodyEndUsers : TeaModel {
            /// <summary>
            /// <para>The connection status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disconnected</description></item>
            /// <item><description>1: connecting</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>The ID of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmucyy****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The display name of the enterprise AD account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("DisplayNameNew")]
            [Validation(Required=false)]
            public string DisplayNameNew { get; set; }

            /// <summary>
            /// <para>The email address of the authorized user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("EndUserEmail")]
            [Validation(Required=false)]
            public string EndUserEmail { get; set; }

            /// <summary>
            /// <para>The ID of the authorized user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The username of the authorized user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            /// <summary>
            /// <para>The mobile number of the authorized user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("EndUserPhone")]
            [Validation(Required=false)]
            public string EndUserPhone { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Note</para>
            /// </summary>
            [NameInMap("EndUserRemark")]
            [Validation(Required=false)]
            public string EndUserRemark { get; set; }

            /// <summary>
            /// <para>The user account type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SIMPLE: convenience account</description></item>
            /// <item><description>AD_CONNECTOR: enterprise Active Directory (AD) account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("EndUserType")]
            [Validation(Required=false)]
            public string EndUserType { get; set; }

            /// <summary>
            /// <para>The appended information.</para>
            /// </summary>
            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public DescribeUsersInGroupResponseBodyEndUsersExternalInfo ExternalInfo { get; set; }
            public class DescribeUsersInGroupResponseBodyEndUsersExternalInfo : TeaModel {
                /// <summary>
                /// <para>The external name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nameDemo</para>
                /// </summary>
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                /// <summary>
                /// <para>The employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud computer that is used by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ud-i896ze8hazpvl****</para>
            /// </summary>
            [NameInMap("UserDesktopId")]
            [Validation(Required=false)]
            public string UserDesktopId { get; set; }

            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

            /// <summary>
            /// <para>Details about the seats of users.</para>
            /// </summary>
            [NameInMap("UserSetPropertiesModels")]
            [Validation(Required=false)]
            public List<DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModels> UserSetPropertiesModels { get; set; }
            public class DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModels : TeaModel {
                /// <summary>
                /// <para>The property ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("PropertyId")]
                [Validation(Required=false)]
                public long? PropertyId { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The property type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: system property</description></item>
                /// <item><description>2: custom property</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PropertyType")]
                [Validation(Required=false)]
                public int? PropertyType { get; set; }

                /// <summary>
                /// <para>Details about property values.</para>
                /// </summary>
                [NameInMap("PropertyValues")]
                [Validation(Required=false)]
                public List<DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModelsPropertyValues> PropertyValues { get; set; }
                public class DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModelsPropertyValues : TeaModel {
                    /// <summary>
                    /// <para>The property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    /// <summary>
                    /// <para>The ID of the property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nameDemo</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The total number of authorized users that are connected to cloud computers of the cloud computer share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OnlineUsersCount")]
        [Validation(Required=false)]
        public int? OnlineUsersCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserOuPath")]
        [Validation(Required=false)]
        public string UserOuPath { get; set; }

        /// <summary>
        /// <para>The total number of authorized users of the cloud computer share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsersCount")]
        [Validation(Required=false)]
        public int? UsersCount { get; set; }

    }

}
