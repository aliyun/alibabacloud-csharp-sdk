// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class CreateMemoryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm_bfaf7e110b6d4359977d1686a3f8</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AutoUpdate")]
        [Validation(Required=false)]
        public bool? AutoUpdate { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("ExpirationTime")]
        [Validation(Required=false)]
        public int? ExpirationTime { get; set; }

        [NameInMap("MessagesJson")]
        [Validation(Required=false)]
        public string MessagesJson { get; set; }

        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public string MetaDataShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>profile_project</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD51C0ED-4666-13DA-BC7D-C0D21CBE16C9</para>
        /// </summary>
        [NameInMap("UserDefinedId")]
        [Validation(Required=false)]
        public string UserDefinedId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-jb5sabg80b4ts71g</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
