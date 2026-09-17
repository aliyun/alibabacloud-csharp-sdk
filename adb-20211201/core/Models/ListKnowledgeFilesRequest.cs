// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListKnowledgeFilesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp19aaaaaa****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The JSON string of the file ID array. A maximum of 200 positive integers are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1001,1002,1003]</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIds { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. If this parameter is not specified, Ray uses a default value of 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. If this parameter is not specified, Ray uses a default value of 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The processing status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PENDING</description></item>
        /// <item><description>PROCESSING</description></item>
        /// <item><description>COMPLETED</description></item>
        /// <item><description>FAILED</description></item>
        /// <item><description>DUPLICATED</description></item>
        /// <item><description>SKIPPED</description></item>
        /// </list>
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
