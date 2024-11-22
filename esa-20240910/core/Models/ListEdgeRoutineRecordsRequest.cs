// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeRoutineRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The match mode to filter the record names.</para>
        /// <list type="bullet">
        /// <item><description><b>fuzzy</b>: fuzzy match.</description></item>
        /// <item><description><b>prefix</b>: match by prefix.</description></item>
        /// <item><description><b>suffix</b>: match by suffix.</description></item>
        /// <item><description><b>exact</b> (default): exact match .</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("RecordMatchType")]
        [Validation(Required=false)]
        public string RecordMatchType { get; set; }

        /// <summary>
        /// <para>The record name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.example.com</para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The website ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
