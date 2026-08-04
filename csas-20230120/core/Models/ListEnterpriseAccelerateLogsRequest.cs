// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListEnterpriseAccelerateLogsRequest : TeaModel {
        /// <summary>
        /// <para>The current page number displayed during paged queries. Value range: 1 to 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Department.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>Endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jfrog.cea.vwah.vwgroup.com</para>
        /// </summary>
        [NameInMap("DstAddr")]
        [Validation(Required=false)]
        public string DstAddr { get; set; }

        /// <summary>
        /// <para>End time, UNIX timestamp, in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748422694</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The number of items per page for paged queries. Value range: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Query mode. Only the DstAddr field supports the following modes:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Exact</b>: Term query</para>
        /// </description></item>
        /// <item><description><para><b>Fuzzy</b>: Fuzzy query</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exact</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>Start time, UNIX timestamp, in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748419094</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
