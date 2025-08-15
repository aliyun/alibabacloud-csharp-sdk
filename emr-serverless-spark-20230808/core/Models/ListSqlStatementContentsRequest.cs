// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListSqlStatementContentsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://oss-<b><b>.cn-hangzhou.oss-dls.aliyuncs.com/w-86a9a4da</b>*<b>a1/spark/logs/jr-b737b</b></b>6164d/driver/st-afde7******bb3f</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
