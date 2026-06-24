// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEventRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Start time for event query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1746516590000</para>
        /// </summary>
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>End time for event query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1746775790000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Page number for paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>Number of entries per page for paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Object content used for filtering. This parameter is optional. If empty, event records for all instances are returned. Note: The value passed must correspond to the selected filter type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**</para>
        /// </summary>
        [NameInMap("termContent")]
        [Validation(Required=false)]
        public string TermContent { get; set; }

        /// <summary>
        /// <para>Object type used for filtering. This parameter is optional. If empty, event records of all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("termType")]
        [Validation(Required=false)]
        public string TermType { get; set; }

    }

}
