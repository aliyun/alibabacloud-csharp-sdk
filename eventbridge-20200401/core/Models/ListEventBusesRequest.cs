// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventBusesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return in a request. You can use this parameter and NextToken to implement paging.</para>
        /// <remarks>
        /// <para> A maximum of 100 entries can be returned in a request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The prefix of the names of the event buses that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My</para>
        /// </summary>
        [NameInMap("NamePrefix")]
        [Validation(Required=false)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// <para>If you configure Limit and excess return values exist, this parameter is returned. You can use this parameter and Limit to implement paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
