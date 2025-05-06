// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListKyuubiSparkApplicationsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that is submitted by using a Kyuubi gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark-339f844005b6404c95f9f7c7a13b****</para>
        /// </summary>
        [NameInMap("applicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The name of the Spark application that is submitted by using a Kyuubi gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kyuubi-connection-spark-sql-anonymous-fa9a5e73-b4b1-474a-b****</para>
        /// </summary>
        [NameInMap("applicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The range of start time.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTimeShrink { get; set; }

    }

}
