// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowPublish")]
        [Validation(Required=false)]
        public bool? AllowPublish { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowShare")]
        [Validation(Required=false)]
        public bool? AllowShare { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowViewAll")]
        [Validation(Required=false)]
        public bool? AllowViewAll { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DefaultShareToAll")]
        [Validation(Required=false)]
        public bool? DefaultShareToAll { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyAdminCreateDatasource")]
        [Validation(Required=false)]
        public bool? OnlyAdminCreateDatasource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseComment")]
        [Validation(Required=false)]
        public bool? UseComment { get; set; }

        [NameInMap("WorkspaceDescription")]
        [Validation(Required=false)]
        public string WorkspaceDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
