// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAccountingReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The list serialized in the JSON format. The list contains multiple records.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAccountingReportResponseBodyData Data { get; set; }
        public class GetAccountingReportResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<string> Data { get; set; }

        }

        /// <summary>
        /// <para>The list serialized in the JSON format. The list contains the column names of each record in the Data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;user\&quot;,\&quot;coreTime\&quot;,\&quot;usedMem\&quot;]</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1DCB399-9333-4B38-A35A-0BDFABC71881</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of CPU cores in the queried cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>261300</para>
        /// </summary>
        [NameInMap("TotalCoreTime")]
        [Validation(Required=false)]
        public int? TotalCoreTime { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
