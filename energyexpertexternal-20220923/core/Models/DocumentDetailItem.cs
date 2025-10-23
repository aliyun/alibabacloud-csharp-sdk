// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class DocumentDetailItem : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("docHash")]
        [Validation(Required=false)]
        public string DocHash { get; set; }

        [NameInMap("docName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("jobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("originDocName")]
        [Validation(Required=false)]
        public string OriginDocName { get; set; }

        [NameInMap("originDocUrl")]
        [Validation(Required=false)]
        public string OriginDocUrl { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
