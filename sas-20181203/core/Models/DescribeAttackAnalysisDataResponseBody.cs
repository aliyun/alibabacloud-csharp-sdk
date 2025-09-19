// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAttackAnalysisDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The attack events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>client_url</b>: the URL of the attack request.</para>
        /// </description></item>
        /// <item><description><para><b>internetIp</b>: the IP address of the asset.</para>
        /// </description></item>
        /// <item><description><para><b>instanceName</b>: the name of the asset.</para>
        /// </description></item>
        /// <item><description><para><b>table_src</b>: the data source.</para>
        /// </description></item>
        /// <item><description><para><b>uuid</b>: the UUID of the asset.</para>
        /// </description></item>
        /// <item><description><para><b>crack_method</b>: the method of the attack request.</para>
        /// </description></item>
        /// <item><description><para><b>crack_hour</b>: the attack time.</para>
        /// </description></item>
        /// <item><description><para><b>crack_src_ip</b>: the IP address from which the attack is launched.</para>
        /// </description></item>
        /// <item><description><para><b>instanceId</b>: the ID of the asset.</para>
        /// </description></item>
        /// <item><description><para><b>dst_port</b>: the attacked port.</para>
        /// </description></item>
        /// <item><description><para><b>client_ip</b>: the attacked IP address.</para>
        /// </description></item>
        /// <item><description><para><b>location</b>: the region from which the attack is launched.</para>
        /// </description></item>
        /// <item><description><para><b>aliuid</b>: the ID of the Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><b>crack_cnt</b>: the number of times that the attack is launched.</para>
        /// </description></item>
        /// <item><description><para><b>crack_type</b>: the type of the attack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>113</b>: improper authorization.</description></item>
        /// <item><description><b>112</b>: redirection attack.</description></item>
        /// <item><description><b>upload</b>: vulnerability upload.</description></item>
        /// <item><description><b>other</b>: others.</description></item>
        /// <item><description><b>webshell</b>: trojan script.</description></item>
        /// <item><description><b>201</b>: suspicious connection.</description></item>
        /// <item><description><b>9</b>: brute-force attack on Microsoft SQL Server.</description></item>
        /// <item><description><b>5</b>: SSH brute-force attack.</description></item>
        /// <item><description><b>6</b>: RDP brute-force attack.</description></item>
        /// <item><description><b>lfi</b>: local file inclusion.</description></item>
        /// <item><description><b>7</b>: code execution.</description></item>
        /// <item><description><b>sqli</b>: SQL injection.</description></item>
        /// <item><description><b>209</b>: web attack.</description></item>
        /// <item><description><b>31</b>: buffer overflow.</description></item>
        /// <item><description><b>3</b>: brute-force attack on MySQL.</description></item>
        /// <item><description><b>30</b>: clickjacking.</description></item>
        /// <item><description><b>4</b>: FTP brute-force attack.</description></item>
        /// <item><description><b>bypass</b>: unauthorized access.</description></item>
        /// <item><description><b>33</b>: format string.</description></item>
        /// <item><description><b>deeplearning</b>: others.</description></item>
        /// <item><description><b>32</b>: integer overflow.</description></item>
        /// <item><description><b>203</b>: brute-force attack.</description></item>
        /// <item><description><b>34</b>: race condition.</description></item>
        /// <item><description><b>rfi</b>: remote file inclusion.</description></item>
        /// <item><description><b>0</b>: SQL injection attack.</description></item>
        /// <item><description><b>212</b>: mining behavior.</description></item>
        /// <item><description><b>213</b>: reverse shell.</description></item>
        /// <item><description><b>211</b>: worm.</description></item>
        /// <item><description><b>61</b>: session timeout.</description></item>
        /// <item><description><b>20</b>: directory traversal.</description></item>
        /// <item><description><b>xss</b>: XSS attack.</description></item>
        /// <item><description><b>22</b>: unauthorized access.</description></item>
        /// <item><description><b>21</b>: scan attack.</description></item>
        /// <item><description><b>24</b>: file modification.</description></item>
        /// <item><description><b>26</b>: file deletion.</description></item>
        /// <item><description><b>25</b>: file reading.</description></item>
        /// <item><description><b>28</b>: CRLF injection.</description></item>
        /// <item><description><b>27</b>: logic error.</description></item>
        /// <item><description><b>29</b>: template injection.</description></item>
        /// <item><description><b>csrf</b>: CSRF.</description></item>
        /// <item><description><b>path</b>: directory traversal.</description></item>
        /// <item><description><b>crlf</b>: CRLF.</description></item>
        /// <item><description><b>102</b>: CSRF.</description></item>
        /// <item><description><b>103</b>: server-side request forgery (SSRF).</description></item>
        /// <item><description><b>101</b>: XSS.</description></item>
        /// <item><description><b>11</b>: file inclusion.</description></item>
        /// <item><description><b>10</b>: file upload.</description></item>
        /// <item><description><b>12</b>: vulnerability upload.</description></item>
        /// <item><description><b>15</b>: unauthorized access.</description></item>
        /// <item><description><b>14</b>: information leakage.</description></item>
        /// <item><description><b>17</b>: XML entity injection.</description></item>
        /// <item><description><b>16</b>: insecure configuration.</description></item>
        /// <item><description><b>19</b>: Lightweight Directory Access Protocol (LDAP) injection.</description></item>
        /// <item><description><b>18</b>: XPath injection.</description></item>
        /// <item><description><b>codei</b>: code execution.</description></item>
        /// <item><description><b>ai_webshell</b>: intelligent defense against webshell upload.</description></item>
        /// <item><description><b>alinet_webrce</b>: adaptive web attack defense.</description></item>
        /// <item><description><b>210</b>: JSP webshell upload.</description></item>
        /// <item><description><b>161</b>: webshell upload.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;crack_hour\&quot;:1662480000000,\&quot;crack_cnt\&quot;:471},{\&quot;crack_hour\&quot;:1662483600000,\&quot;crack_cnt\&quot;:461},{\&quot;crack_hour\&quot;:1662487200000,\&quot;crack_cnt\&quot;:445},{\&quot;crack_hour\&quot;:1662490800000,\&quot;crack_cnt\&quot;:471},{\&quot;crack_hour\&quot;:1662494400000,\&quot;crack_cnt\&quot;:534},{\&quot;crack_hour\&quot;:1662498000000,\&quot;crack_cnt\&quot;:652},{\&quot;crack_hour\&quot;:1662501600000,\&quot;crack_cnt\&quot;:706},{\&quot;crack_hour\&quot;:1662505200000,\&quot;crack_cnt\&quot;:613},{\&quot;crack_hour\&quot;:1662508800000,\&quot;crack_cnt\&quot;:578},{\&quot;crack_hour\&quot;:1662512400000,\&quot;crack_cnt\&quot;:577},{\&quot;crack_hour\&quot;:1662516000000,\&quot;crack_cnt\&quot;:616},{\&quot;crack_hour\&quot;:1662519600000,\&quot;crack_cnt\&quot;:597},{\&quot;crack_hour\&quot;:1662523200000,\&quot;crack_cnt\&quot;:575},{\&quot;crack_hour\&quot;:1662526800000,\&quot;crack_cnt\&quot;:507}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C1AE3F3-18FA-4108-BBB9-AFA1A032756C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of attack events returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
