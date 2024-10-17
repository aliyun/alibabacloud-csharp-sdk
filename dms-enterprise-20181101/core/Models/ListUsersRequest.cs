// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>**</para>
        /// <para>Valid values: 10, 20, 50, and 100.**** Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The role that is assigned to the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>USER</b>: a regular user.</description></item>
        /// <item><description><b>DBA</b> : a database administrator (DBA).</description></item>
        /// <item><description><b>ADMIN</b>: a Data Management (DMS) administrator.</description></item>
        /// <item><description><b>SECURITY_ADMIN</b>: a security administrator.</description></item>
        /// <item><description><b>STRUCT_READ_ONLY</b>: a schema read-only user.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To check your role, move the pointer over the profile picture in the upper-right corner of the DMS console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DBA</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The search keyword. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The status of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The user is normal.</description></item>
        /// <item><description><b>DISABLE</b>: The user is disabled.</description></item>
        /// <item><description><b>DELETE</b>: The user is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("UserState")]
        [Validation(Required=false)]
        public string UserState { get; set; }

    }

}
