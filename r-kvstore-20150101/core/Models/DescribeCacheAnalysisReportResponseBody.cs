// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeCacheAnalysisReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of big keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;db&quot;:&quot;0&quot;,&quot;qps&quot;:0,&quot;keyType&quot;:&quot;list&quot;,&quot;isExpired&quot;:&quot;no&quot;,&quot;analysisType&quot;:&quot;BIGKEY&quot;,&quot;key&quot;:&quot;mylist&quot;,&quot;memory&quot;:1005377,&quot;size&quot;:200000}]</para>
        /// </summary>
        [NameInMap("BigKeys")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> BigKeys { get; set; }

        /// <summary>
        /// <para>The list of hot keys.</para>
        /// <remarks>
        /// <para>Hot key analysis is not supported. No value is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("HotKeys")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> HotKeys { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A057C066-C3F5-4CC9-9FE4-A8D8B0DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned across all pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
