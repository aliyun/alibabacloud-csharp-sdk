// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>If you do not specify the <b>MaxResults</b> request parameter, you do not need to query data in batches. The value of the <b>MaxResults</b> response parameter indicates the total number of list entries.</description></item>
        /// <item><description>If you specify the <b>MaxResults</b> request parameter, you must query data in batches. The value of the <b>MaxResults</b> response parameter indicates the number of list entries in the current batch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40831b4f-d91d-4796-9589-ad306ec528d5</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
