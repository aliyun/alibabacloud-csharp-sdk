// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSuspiciousStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the asset groups that you want to query. Separate multiple asset group IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9997897</para>
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.12.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
