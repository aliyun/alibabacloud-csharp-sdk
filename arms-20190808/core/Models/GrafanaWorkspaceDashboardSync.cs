// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceDashboardSync : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testTitle</para>
        /// </summary>
        [NameInMap("dashboardTitle")]
        [Validation(Required=false)]
        public string DashboardTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://g.console.aliyun.com/d/1098370038733503-14960236-422-3/ack-pro-apiserver">https://g.console.aliyun.com/d/1098370038733503-14960236-422-3/ack-pro-apiserver</a></para>
        /// </summary>
        [NameInMap("dashboardURL")]
        [Validation(Required=false)]
        public string DashboardURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxdvxsea</para>
        /// </summary>
        [NameInMap("dashboardUid")]
        [Validation(Required=false)]
        public string DashboardUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("folderTitle")]
        [Validation(Required=false)]
        public string FolderTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://g.console.aliyun.com/d/1098370038733503-14960236-422-3/ack-pro-apiserver">https://g.console.aliyun.com/d/1098370038733503-14960236-422-3/ack-pro-apiserver</a></para>
        /// </summary>
        [NameInMap("folderURL")]
        [Validation(Required=false)]
        public string FolderURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vxeupqn</para>
        /// </summary>
        [NameInMap("folderUid")]
        [Validation(Required=false)]
        public string FolderUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
