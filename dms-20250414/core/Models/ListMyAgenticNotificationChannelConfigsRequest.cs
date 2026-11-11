// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListMyAgenticNotificationChannelConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The notification channel type used to filter results. If you do not specify this parameter, all personal notification channels are returned. Currently, only FEISHU (Lark) is supported. Specifying other values results in a parameter error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The paging token for the paged query. Do not specify this parameter for the first query. To query the next page, specify the NextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MjA</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
