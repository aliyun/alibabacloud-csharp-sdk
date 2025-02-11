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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The language of file titles and error messages. Valid values:</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the diagnostic information about SQL statements for an AnalyticDB for MySQL cluster, including the query ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021070216432217201616806503453</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The IP address and port number of the AnalyticDB for MySQL frontend node on which the SQL statement is executed.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the diagnostic information about SQL statements for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster, including the IP address and port number of the frontend node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.45.<em><b>.</b></em>:3145</para>
        /// </summary>
        [NameInMap("ProcessRcHost")]
        [Validation(Required=false)]
        public string ProcessRcHost { get; set; }

        /// <summary>
        /// <para>The execution start time of the SQL statement. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the diagnostic information about SQL statements for an AnalyticDB for MySQL cluster, including the execution start time of the SQL statement.</para>
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
        /// <item><description><b>running</b></description></item>
        /// <item><description><b>finished</b></description></item>
        /// <item><description><b>failed</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/308207.html">DescribeDiagnosisRecords</a> operation to query the diagnostic information about SQL statements for an AnalyticDB for MySQL cluster, including the status of the SQL statement.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("ProcessState")]
        [Validation(Required=false)]
        public string ProcessState { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
