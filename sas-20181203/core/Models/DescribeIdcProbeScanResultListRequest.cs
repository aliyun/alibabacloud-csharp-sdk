// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeScanResultListRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions for assets. This parameter is in JSON format. Parameter names are case-sensitive.</para>
        /// <remarks>
        /// <para>You can search for assets by instance ID, instance name, VPC ID, region, or public IP address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;scannedIp\&quot;,\&quot;value\&quot;:\&quot;192.168.2.11\&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the scan discovery period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1720006819000</para>
        /// </summary>
        [NameInMap("FoundEndTime")]
        [Validation(Required=false)]
        public long? FoundEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the scan discovery period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1720006818000</para>
        /// </summary>
        [NameInMap("FoundStartTime")]
        [Validation(Required=false)]
        public long? FoundStartTime { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The search conditions are in a logical <b>OR</b> relationship.</description></item>
        /// <item><description><b>AND</b>: The search conditions are in a logical <b>AND</b> relationship.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status list of the corresponding probes. Separate multiple values with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: active</description></item>
        /// <item><description><b>1</b>: ignored</description></item>
        /// <item><description><b>2</b>: invalid</description></item>
        /// <item><description><b>3</b>: expired</description></item>
        /// <item><description><b>4</b>: probe does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0,1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
