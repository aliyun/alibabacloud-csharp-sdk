// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CheckUserAuthToMsceneRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ALIPUBE5C3F6D091419</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("AuthToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9999202604200001</para>
        /// </summary>
        [NameInMap("MiniProgramId")]
        [Validation(Required=false)]
        public string MiniProgramId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>QSz8YsUpMRiCAv0yKLi0OVGd0lQSg9CQkYI148GNIWE=</para>
        /// </summary>
        [NameInMap("OpenUid")]
        [Validation(Required=false)]
        public string OpenUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mPaaS_Goosefish</para>
        /// </summary>
        [NameInMap("PlatformId")]
        [Validation(Required=false)]
        public string PlatformId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZXCXMAHQ-zh_CN</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
