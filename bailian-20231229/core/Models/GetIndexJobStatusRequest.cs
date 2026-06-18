// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetIndexJobStatusRequest : TeaModel {
        /// <summary>
        /// <para>The knowledge base ID, which is the <c>Data.Id</c> returned by the <b>CreateIndex</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The knowledge base job ID, which is the <c>Data.Id</c> returned by the <b>SubmitIndexJob</b> or <b>SubmitIndexAddDocumentsJob</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230718xxxx-146c93bf</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The <b>SubmitIndexJob</b> and <b>SubmitIndexAddDocumentsJob</b> operations support batch file import. This operation returns the overall knowledge base job status <c>Status</c> and the import status of each file <c>Document.Status</c>. If there are many files, use the <c>PageNumber</c> parameter for paging. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of file import tasks to display per page in a paged query. No maximum limit. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
