// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class SearchTracesByPageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-08 15:03:21</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("minDuration")]
        [Validation(Required=false)]
        public long? MinDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/demo/queryNotExistDB/11</para>
        /// </summary>
        [NameInMap("operationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev-sellercenter</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-31 11:10:22</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
