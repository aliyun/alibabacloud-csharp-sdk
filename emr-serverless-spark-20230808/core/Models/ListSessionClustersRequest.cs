// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListSessionClustersRequest : TeaModel {
        /// <summary>
        /// <para>The session type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NOTEBOOK</description></item>
        /// <item><description>THRIFT</description></item>
        /// <item><description>SQL</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("queueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr-spark-demo-job</para>
        /// </summary>
        [NameInMap("sessionClusterId")]
        [Validation(Required=false)]
        public string SessionClusterId { get; set; }

    }

}
