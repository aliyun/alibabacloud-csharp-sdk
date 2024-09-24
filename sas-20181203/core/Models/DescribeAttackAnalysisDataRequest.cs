// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAttackAnalysisDataRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to encode the value of the <b>client_url</b> field in the query results by using the Base64 algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Base64")]
        [Validation(Required=false)]
        public string Base64 { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page <b>1</b>.</para>
        /// <remarks>
        /// <para> If the Type parameter is set to <b>DETAILS</b>, you must specify the CurrentPage parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The condition that is used to filter attack events.</para>
        /// <remarks>
        /// <para> The following list describes the valid values of crack_type:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>3: brute-force attack on MySQL</para>
        /// </description></item>
        /// <item><description><para>4: FTP brute-force attack</para>
        /// </description></item>
        /// <item><description><para>5: SSH brute-force attack</para>
        /// </description></item>
        /// <item><description><para>6: RDP brute-force attack</para>
        /// </description></item>
        /// <item><description><para>9: brute-force attack on Microsoft SQL Server</para>
        /// </description></item>
        /// <item><description><para>101: intercepted attack on Java Struts 2</para>
        /// </description></item>
        /// <item><description><para>102: intercepted attack on Redis</para>
        /// </description></item>
        /// <item><description><para>103: communication with AntSword Webshell</para>
        /// </description></item>
        /// <item><description><para>104: communication with China Chopper Webshell</para>
        /// </description></item>
        /// <item><description><para>133: communication with XISE Webshell</para>
        /// </description></item>
        /// <item><description><para>sqli: SQL injection</para>
        /// </description></item>
        /// <item><description><para>codei: code execution</para>
        /// </description></item>
        /// <item><description><para>xss: cross-site scripting (XSS)</para>
        /// </description></item>
        /// <item><description><para>lfi: local file inclusion</para>
        /// </description></item>
        /// <item><description><para>rfi: remote file inclusion</para>
        /// </description></item>
        /// <item><description><para>webshell: trojan script</para>
        /// </description></item>
        /// <item><description><para>upload: vulnerability upload</para>
        /// </description></item>
        /// <item><description><para>path: directory traversal</para>
        /// </description></item>
        /// <item><description><para>bypass: unauthorized access</para>
        /// </description></item>
        /// <item><description><para>csrf: cross-site request forgery (CSRF)</para>
        /// </description></item>
        /// <item><description><para>crlf: carriage return line feed (CRLF)</para>
        /// </description></item>
        /// <item><description><para>other: others</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;crack_type&quot;:&quot;9&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The timestamp when the attack stops. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649040221</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <remarks>
        /// <para> If the Type parameter is set to <b>DETAILS</b>, you must specify the PageSize parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The timestamp at which the attack starts. By default, the statistics of the previous seven days are queried. Unit: seconds.</para>
        /// <remarks>
        /// <para> The start time that you specify must be within the previous 40 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1644027670</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The details of attack analysis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TOTAL</b>: number of attacks</description></item>
        /// <item><description><b>TREND</b>: attack trend</description></item>
        /// <item><description><b>PIE_CHART</b>: distribution of attacks by type</description></item>
        /// <item><description><b>SOURCE_TOP</b>: top 5 attack sources</description></item>
        /// <item><description><b>CLIENT_TOP</b>: top 5 attacked assets</description></item>
        /// <item><description><b>DETAILS</b>: attack details</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the Type parameter is set to <b>DETAILS</b>, you must specify the CurrentPage and PageSize parameters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DETAILS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
