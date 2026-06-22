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
        /// <item><description><para><b>113</b>: improper authorization.</para>
        /// </description></item>
        /// <item><description><para><b>112</b>: redirection attack.</para>
        /// </description></item>
        /// <item><description><para><b>upload</b>: vulnerability upload.</para>
        /// </description></item>
        /// <item><description><para><b>other</b>: others.</para>
        /// </description></item>
        /// <item><description><para><b>webshell</b>: trojan script.</para>
        /// </description></item>
        /// <item><description><para><b>201</b>: suspicious connection.</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: brute-force attack on Microsoft SQL Server.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: SSH brute-force attack.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: RDP brute-force attack.</para>
        /// </description></item>
        /// <item><description><para><b>lfi</b>: local file inclusion.</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: code execution.</para>
        /// </description></item>
        /// <item><description><para><b>sqli</b>: SQL injection.</para>
        /// </description></item>
        /// <item><description><para><b>209</b>: web attack.</para>
        /// </description></item>
        /// <item><description><para><b>31</b>: buffer overflow.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: brute-force attack on MySQL.</para>
        /// </description></item>
        /// <item><description><para><b>30</b>: clickjacking.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: FTP brute-force attack.</para>
        /// </description></item>
        /// <item><description><para><b>bypass</b>: unauthorized access.</para>
        /// </description></item>
        /// <item><description><para><b>33</b>: format string.</para>
        /// </description></item>
        /// <item><description><para><b>deeplearning</b>: others.</para>
        /// </description></item>
        /// <item><description><para><b>32</b>: integer overflow.</para>
        /// </description></item>
        /// <item><description><para><b>203</b>: brute-force attack.</para>
        /// </description></item>
        /// <item><description><para><b>34</b>: race condition.</para>
        /// </description></item>
        /// <item><description><para><b>rfi</b>: remote file inclusion.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: SQL injection attack.</para>
        /// </description></item>
        /// <item><description><para><b>212</b>: mining behavior.</para>
        /// </description></item>
        /// <item><description><para><b>213</b>: reverse shell.</para>
        /// </description></item>
        /// <item><description><para><b>211</b>: worm.</para>
        /// </description></item>
        /// <item><description><para><b>61</b>: session timeout.</para>
        /// </description></item>
        /// <item><description><para><b>20</b>: directory traversal.</para>
        /// </description></item>
        /// <item><description><para><b>xss</b>: XSS attack.</para>
        /// </description></item>
        /// <item><description><para><b>22</b>: unauthorized access.</para>
        /// </description></item>
        /// <item><description><para><b>21</b>: scan attack.</para>
        /// </description></item>
        /// <item><description><para><b>24</b>: file modification.</para>
        /// </description></item>
        /// <item><description><para><b>26</b>: file deletion.</para>
        /// </description></item>
        /// <item><description><para><b>25</b>: file reading.</para>
        /// </description></item>
        /// <item><description><para><b>28</b>: CRLF injection.</para>
        /// </description></item>
        /// <item><description><para><b>27</b>: logic error.</para>
        /// </description></item>
        /// <item><description><para><b>29</b>: template injection.</para>
        /// </description></item>
        /// <item><description><para><b>csrf</b>: CSRF.</para>
        /// </description></item>
        /// <item><description><para><b>path</b>: directory traversal.</para>
        /// </description></item>
        /// <item><description><para><b>crlf</b>: CRLF.</para>
        /// </description></item>
        /// <item><description><para><b>102</b>: CSRF.</para>
        /// </description></item>
        /// <item><description><para><b>103</b>: server-side request forgery (SSRF).</para>
        /// </description></item>
        /// <item><description><para><b>101</b>: XSS.</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: file inclusion.</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: file upload.</para>
        /// </description></item>
        /// <item><description><para><b>12</b>: vulnerability upload.</para>
        /// </description></item>
        /// <item><description><para><b>15</b>: unauthorized access.</para>
        /// </description></item>
        /// <item><description><para><b>14</b>: information leakage.</para>
        /// </description></item>
        /// <item><description><para><b>17</b>: XML entity injection.</para>
        /// </description></item>
        /// <item><description><para><b>16</b>: insecure configuration.</para>
        /// </description></item>
        /// <item><description><para><b>19</b>: Lightweight Directory Access Protocol (LDAP) injection.</para>
        /// </description></item>
        /// <item><description><para><b>18</b>: XPath injection.</para>
        /// </description></item>
        /// <item><description><para><b>codei</b>: code execution.</para>
        /// </description></item>
        /// <item><description><para><b>ai_webshell</b>: intelligent defense against webshell upload.</para>
        /// </description></item>
        /// <item><description><para><b>alinet_webrce</b>: adaptive web attack defense.</para>
        /// </description></item>
        /// <item><description><para><b>210</b>: JSP webshell upload.</para>
        /// </description></item>
        /// <item><description><para><b>161</b>: webshell upload.</para>
        /// </description></item>
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
