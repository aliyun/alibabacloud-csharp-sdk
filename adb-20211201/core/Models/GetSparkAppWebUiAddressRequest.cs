// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppWebUiAddressRequest : TeaModel {
        /// <summary>
        /// <para>The Spark application ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/455888.html">ListSparkApps</a> operation to query Spark application IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s202205201533hz1209892000****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amv-uf6g8w25jacm7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}
