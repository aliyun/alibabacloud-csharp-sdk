// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetIndexJobStatusRequest : TeaModel {
        /// <summary>
        /// <para>The knowledge base ID, which is the Data.Id returned by the CreateIndex operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The knowledge base job task ID, which is the Data.Id returned by the SubmitIndexJob or SubmitIndexAddDocumentsJob operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230718xxxx-146c93bf</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Both the <b>SubmitIndexJob</b> and <b>SubmitIndexAddDocumentsJob</b> operations support batch file import. The fields returned by this operation include the overall status of the knowledge base job task (<c>Status</c>) and the import status of each file (<c>Document.Status</c>). If a large number of files are imported, you can use the <c>PageNumber</c> parameter for paging. The starting value is 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of file import tasks to return on each page during paging. Maximum value: unlimited. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
