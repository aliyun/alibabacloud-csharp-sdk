// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddProjectMemberToRoleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. We recommend that you set this parameter to a UUID. This parameter is used to uniquely identify the API operation call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can call the <a href="https://help.aliyun.com/document_detail/2780068.html">ListProjects</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The code of the role that you want to assign to a member of the DataWorks workspace. You can call the <a href="https://help.aliyun.com/document_detail/2780079.html">ListProjectRoles</a> operation to query the codes of all roles in a DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_project_guest</para>
        /// </summary>
        [NameInMap("RoleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and move the pointer over the profile picture in the upper-right corner to view the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
