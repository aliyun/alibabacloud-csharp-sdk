// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDirectoryTreeRequest : TeaModel {
        /// <summary>
        /// <para>Directory type.</para>
        /// <list type="bullet">
        /// <item><description>Ad-hoc Query: tempCode</description></item>
        /// <item><description>Code Task: codeManage</description></item>
        /// <item><description>Offline Pipeline: offlinePipeline</description></item>
        /// <item><description>Pipeline Custom Component: offlinePipelineCustomPlugin</description></item>
        /// <item><description>Sync Task: dataX</description></item>
        /// <item><description>Real-time Meta Table: streamMeta</description></item>
        /// <item><description>Real-time Custom Source: streamCustomDataSource</description></item>
        /// <item><description>Real-time Compute Template: streamTemplate</description></item>
        /// <item><description>Resource Management: resourceManage</description></item>
        /// <item><description>Offline Function: udfResource</description></item>
        /// <item><description>Real-time Function: streamFunction</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>codeManage</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7081229106458752</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
