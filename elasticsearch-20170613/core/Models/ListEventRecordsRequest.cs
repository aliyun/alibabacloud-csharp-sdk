// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEventRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The start time for the event query. Specify a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1746516590000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The end time for the event query. Specify a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1746775790000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number in the paging Settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page in the paging Settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The content of the object to filter. If this parameter is empty, event records for all instances are returned. Note: Specify the corresponding value based on the filter type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**</para>
        /// </summary>
        [NameInMap("termContent")]
        [Validation(Required=false)]
        public string TermContent { get; set; }

        /// <summary>
        /// <para>The object type to filter. If this parameter is empty, event records of all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("termType")]
        [Validation(Required=false)]
        public string TermType { get; set; }

    }

}
