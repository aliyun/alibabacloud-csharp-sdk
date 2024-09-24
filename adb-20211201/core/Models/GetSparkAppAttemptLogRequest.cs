// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppAttemptLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the log.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/455887.html">ListSparkAppAttempts</a> operation to query the information about the retry attempts of a Spark application, including the retry log IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s202207151211hz****-0001</para>
        /// </summary>
        [NameInMap("AttemptId")]
        [Validation(Required=false)]
        public string AttemptId { get; set; }

        /// <summary>
        /// <para>The number of log entries to return. Valid values: 1 to 500. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("LogLength")]
        [Validation(Required=false)]
        public long? LogLength { get; set; }

        /// <summary>
        /// <para>The log offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
