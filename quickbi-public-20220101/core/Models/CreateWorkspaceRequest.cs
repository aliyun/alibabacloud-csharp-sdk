// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether reports in the workspace can be made public. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowPublish")]
        [Validation(Required=false)]
        public bool? AllowPublish { get; set; }

        /// <summary>
        /// <para>Specifies whether reports in the workspace can be shared. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowShare")]
        [Validation(Required=false)]
        public bool? AllowShare { get; set; }

        /// <summary>
        /// <para>Specifies whether the workspace is in collaboration mode. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowViewAll")]
        [Validation(Required=false)]
        public bool? AllowViewAll { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant read permissions on the works in the workspace to all workspace members by default. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DefaultShareToAll")]
        [Validation(Required=false)]
        public bool? DefaultShareToAll { get; set; }

        /// <summary>
        /// <para>Specifies whether only administrators can create data sources in the workspace. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyAdminCreateDatasource")]
        [Validation(Required=false)]
        public bool? OnlyAdminCreateDatasource { get; set; }

        /// <summary>
        /// <para>Specifies whether to use table remarks when you create a dataset in the workspace. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseComment")]
        [Validation(Required=false)]
        public bool? UseComment { get; set; }

        /// <summary>
        /// <para>The description of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WorkspaceDescription")]
        [Validation(Required=false)]
        public string WorkspaceDescription { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
