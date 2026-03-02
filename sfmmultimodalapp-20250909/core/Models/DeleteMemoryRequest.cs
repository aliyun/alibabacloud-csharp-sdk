// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class DeleteMemoryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm_bfaf7e110b6d4359977d1686a3f8</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD51C0ED-4666-13DA-BC7D-C0D21CBE16C</para>
        /// </summary>
        [NameInMap("MemoryNodeId")]
        [Validation(Required=false)]
        public string MemoryNodeId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A7C969B-5101-112B-8202-DFAEEA4BFBED</para>
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
