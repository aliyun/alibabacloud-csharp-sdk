// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListRamPolicyExportTasksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mod-43143bd9145a5258</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
