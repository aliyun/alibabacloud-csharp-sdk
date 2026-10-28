// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkSQLDiagnosisAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612475.html">ListSparkApps</a> operation to query the ID of the Spark application.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s202411071444hzdvk486d9d2001****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The collection of diagnostic suggestions.</para>
        /// </summary>
        [NameInMap("DiagnosisInfos")]
        [Validation(Required=false)]
        public List<Adb4MysqlSparkDiagnosisInfo> DiagnosisInfos { get; set; }

        /// <summary>
        /// <para>The actual execution time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ElapsedTime")]
        [Validation(Required=false)]
        public long? ElapsedTime { get; set; }

        /// <summary>
        /// <para>The internal query execution ID of the Spark application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InnerQueryId")]
        [Validation(Required=false)]
        public long? InnerQueryId { get; set; }

        /// <summary>
        /// <para>The operator queue sorted by metrics.</para>
        /// </summary>
        [NameInMap("OperatorListSortedByMetrics")]
        [Validation(Required=false)]
        public DescribeSparkSQLDiagnosisAttributeResponseBodyOperatorListSortedByMetrics OperatorListSortedByMetrics { get; set; }
        public class DescribeSparkSQLDiagnosisAttributeResponseBodyOperatorListSortedByMetrics : TeaModel {
            /// <summary>
            /// <para>The operator queue sorted by execution time.</para>
            /// </summary>
            [NameInMap("OperatorListSortedByExclusiveTime")]
            [Validation(Required=false)]
            public List<SparkOperatorInfo> OperatorListSortedByExclusiveTime { get; set; }

            /// <summary>
            /// <para>The operator queue sorted by maximum memory consumption.</para>
            /// </summary>
            [NameInMap("OperatorListSortedByMaxMemory")]
            [Validation(Required=false)]
            public List<SparkOperatorInfo> OperatorListSortedByMaxMemory { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Spark execution plan tree.</para>
        /// </summary>
        [NameInMap("Root")]
        [Validation(Required=false)]
        public OperatorNode Root { get; set; }

    }

}
