// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchUserRequest : TeaModel {
        /// <summary>
        /// <para>The email address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:123@pds.com">123@pds.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The nickname of the user. The nickname can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdsuer</para>
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The nickname used for fuzzy searches. The nickname can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>la</para>
        /// </summary>
        [NameInMap("nick_name_for_fuzzy")]
        [Validation(Required=false)]
        public string NickNameForFuzzy { get; set; }

        /// <summary>
        /// <para>The mobile number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13900001111</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The role of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>superadmin</description></item>
        /// <item><description>admin</description></item>
        /// <item><description>user</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The state of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: The user is prohibited from logon.</description></item>
        /// <item><description>enabled: The user is in a normal state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The name of the user. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pds</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
