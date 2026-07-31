// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDiagnosisSQLInfoRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the cluster IDs of AnalyticDB for MySQL clusters in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053by****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The language of the file title and error messages in the downloaded file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: simplified Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The query ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the SQL summary information of a specific AnalyticDB for MySQL cluster, including the query ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20210702164322172016168****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The IP address and port number of the AnalyticDB for MySQL frontend node that executes the SQL statement.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the SQL summary information of a specific AnalyticDB for MySQL cluster, including the IP address and port number of the frontend node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.45.<em><b>.</b></em>:3145</para>
        /// </summary>
        [NameInMap("ProcessRcHost")]
        [Validation(Required=false)]
        public string ProcessRcHost { get; set; }

        /// <summary>
        /// <para>The start time of the SQL statement execution. Specify the value as a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the SQL summary information of a specific AnalyticDB for MySQL cluster, including the start time of the SQL statement execution.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1625215402000</para>
        /// </summary>
        [NameInMap("ProcessStartTime")]
        [Validation(Required=false)]
        public long? ProcessStartTime { get; set; }

        /// <summary>
        /// <para>The status of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b>: The SQL statement is being executed.</description></item>
        /// <item><description><b>finished</b>: The SQL statement has been executed.</description></item>
        /// <item><description><b>failed</b>: The SQL statement failed to be executed.<remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the SQL summary information of a specific AnalyticDB for MySQL cluster, including the status of the SQL statement.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("ProcessState")]
        [Validation(Required=false)]
        public string ProcessState { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the region IDs supported by AnalyticDB for MySQL.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
