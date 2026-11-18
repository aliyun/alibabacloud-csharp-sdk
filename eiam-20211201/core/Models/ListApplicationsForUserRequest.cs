// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationsForUserRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs. A single request supports up to 100 application IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;app_mkv7rgt4d7i4u7zqtzev2mxxxx&quot;]</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The query mode. Default value: <b>OnlyDirect</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OnlyDirect: Queries only the direct permissions of the account, which are the applications directly assigned to the account.</description></item>
        /// <item><description>IncludeInherit: Queries both the direct permissions and inherited permissions of the account. Inherited permissions refer to the permissions that the account inherits from its parent organizations or the groups to which it belongs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OnlyDirect</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
