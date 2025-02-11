// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkSQLDiagnosisAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s202411071444hzdvk486d9d2001****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("DiagnosisInfos")]
        [Validation(Required=false)]
        public List<Adb4MysqlSparkDiagnosisInfo> DiagnosisInfos { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ElapsedTime")]
        [Validation(Required=false)]
        public long? ElapsedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InnerQueryId")]
        [Validation(Required=false)]
        public long? InnerQueryId { get; set; }

        [NameInMap("OperatorListSortedByMetrics")]
        [Validation(Required=false)]
        public DescribeSparkSQLDiagnosisAttributeResponseBodyOperatorListSortedByMetrics OperatorListSortedByMetrics { get; set; }
        public class DescribeSparkSQLDiagnosisAttributeResponseBodyOperatorListSortedByMetrics : TeaModel {
            [NameInMap("OperatorListSortedByExclusiveTime")]
            [Validation(Required=false)]
            public List<SparkOperatorInfo> OperatorListSortedByExclusiveTime { get; set; }

            [NameInMap("OperatorListSortedByMaxMemory")]
            [Validation(Required=false)]
            public List<SparkOperatorInfo> OperatorListSortedByMaxMemory { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public OperatorNode Root { get; set; }

    }

}
