// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerJob : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("DebuggerJobId")]
        [Validation(Required=false)]
        public string DebuggerJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc debugger test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2932</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:00Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtFailedTime")]
        [Validation(Required=false)]
        public string GmtFailedTime { get; set; }

        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        [NameInMap("GmtRunningTime")]
        [Validation(Required=false)]
        public string GmtRunningTime { get; set; }

        [NameInMap("GmtStoppedTime")]
        [Validation(Required=false)]
        public string GmtStoppedTime { get; set; }

        [NameInMap("GmtSubmittedTime")]
        [Validation(Required=false)]
        public string GmtSubmittedTime { get; set; }

        [NameInMap("GmtSucceedTime")]
        [Validation(Required=false)]
        public string GmtSucceedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12344556</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace01</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
