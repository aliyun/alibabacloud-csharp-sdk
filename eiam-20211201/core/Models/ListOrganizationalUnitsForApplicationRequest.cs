// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListOrganizationalUnitsForApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>应用角色ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_role_mkv7rgt4ds8d8v0qtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationRoleId")]
        [Validation(Required=false)]
        public string ApplicationRoleId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the organizations that are allowed to access the application. You can query a maximum of 100 organization IDs at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ou_wovwffm62xifdziem7an7xxxxx</para>
        /// </summary>
        [NameInMap("OrganizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
