// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListKnowledgeFilesRequest : TeaModel {
        /// <summary>
        /// <para>The ADB instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp19aaaaaa****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The JSON string of the file ID array, which contains up to 200 positive integers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1001,1002,1003]</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIds { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. If this parameter is not specified, the default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. If this parameter is not specified, the default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The processing status. Valid values: PENDING, PROCESSING, COMPLETED, FAILED, DUPLICATED, and SKIPPED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The stable ID of the authorized user. If this parameter is not specified, all files in the knowledge base can be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>u123</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
