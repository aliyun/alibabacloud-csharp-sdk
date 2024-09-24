// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteProcessInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612397.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-wz9rq819u71ig****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4017</para>
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public long? ProcessInstanceId { get; set; }

        /// <summary>
        /// <para>The project ID, which is the unique identifier of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9839028042592</para>
        /// </summary>
        [NameInMap("ProjectCode")]
        [Validation(Required=false)]
        public long? ProjectCode { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
