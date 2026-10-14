// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppAttemptLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the retry log.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/455887.html">ListSparkAppAttempts</a> operation to query the retry history of an application, which includes the retry log ID.</para>
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
        /// <para>The number of lines in the retry log. Valid values: 1 to 500. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("LogLength")]
        [Validation(Required=false)]
        public long? LogLength { get; set; }

        /// <summary>
        /// <para>The start offset for reading logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of data rows per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
