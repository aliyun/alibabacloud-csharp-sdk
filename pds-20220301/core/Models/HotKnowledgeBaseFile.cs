// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class HotKnowledgeBaseFile : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("action_count")]
        [Validation(Required=false)]
        public long? ActionCount { get; set; }

        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<string> ActionList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1727578860000</para>
        /// </summary>
        [NameInMap("count_at")]
        [Validation(Required=false)]
        public long? CountAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>666ff36c22278f023ec</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4jTsp3AgW</para>
        /// </summary>
        [NameInMap("knowledge_base_id")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a.jpg</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>666ff36c22278f023ec</para>
        /// </summary>
        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

    }

}
