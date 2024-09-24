// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeScanResultListRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions for assets. This parameter is in the JSON format. The value is case-sensitive.</para>
        /// <remarks>
        /// <para> A search condition can be the instance ID, instance name, VPC ID, region, or public IP address. You can call the <a href="https://help.aliyun.com/document_detail/2842671.html">DescribeIdcAssetCriteria</a> operation to query supported search conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;scannedIp\&quot;,\&quot;value\&quot;:\&quot;192.168.2.11\&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the scan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1720006819000</para>
        /// </summary>
        [NameInMap("FoundEndTime")]
        [Validation(Required=false)]
        public long? FoundEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the scan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1720006818000</para>
        /// </summary>
        [NameInMap("FoundStartTime")]
        [Validation(Required=false)]
        public long? FoundStartTime { get; set; }

        /// <summary>
        /// <para>The logical operator that combines multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>****</description></item>
        /// <item><description><b>AND</b>****</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The statuses of the corresponding probes. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The probe is valid.</description></item>
        /// <item><description><b>1</b>: The probe is ignored.</description></item>
        /// <item><description><b>2</b>: The probe is invalid.</description></item>
        /// <item><description><b>3</b>: The probe expired.</description></item>
        /// <item><description><b>4</b>: The probe does not exist.</description></item>
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
