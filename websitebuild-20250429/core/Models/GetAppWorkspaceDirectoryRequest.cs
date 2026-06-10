// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppWorkspaceDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>Session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b7105a2-2999-430b-ba23-ba09149d5434</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>Directory depth (optional; null or 0 returns all levels)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Deep")]
        [Validation(Required=false)]
        public int? Deep { get; set; }

        /// <summary>
        /// <para>Directory path (optional)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

    }

}
