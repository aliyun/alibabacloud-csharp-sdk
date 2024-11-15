// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeChinesePassportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>noPermission</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;data&quot;:{&quot;passportType&quot;:&quot;P&quot;,&quot;countryCode&quot;:&quot;CHN&quot;,&quot;passportNumber&quot;:&quot;E90000082&quot;,&quot;nameEn&quot;:&quot;,ZHENGJIANGANGUX&quot;,&quot;name&quot;:&quot;&quot;,&quot;sex&quot;:&quot;3.7F&quot;,&quot;birthPlace&quot;:&quot;北京/BEIJIHG&quot;,&quot;nationality&quot;:&quot;&quot;,&quot;issuePlace&quot;:&quot;山东/SHANDON&quot;,&quot;issueAuthority&quot;:&quot;公安部出入境管理局&quot;,&quot;mrzLine1&quot;:&quot;POCHNZHENGJIAN&lt;&lt;YANGBEN&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&quot;,&quot;mrzLine2&quot;:&quot;E900000821CHN8108038F2110189NGKELMPONBPJB978&quot;,&quot;validToDate&quot;:&quot;2921.DCF.3B&quot;,&quot;birthDate&quot;:&quot;08.1981&quot;,&quot;issueDate&quot;:&quot;91.1010.19&quot;},&quot;ftype&quot;:0,&quot;height&quot;:186,&quot;orgHeight&quot;:186,&quot;orgWidth&quot;:271,&quot;prism_keyValueInfo&quot;:[{&quot;key&quot;:&quot;passportType&quot;,&quot;keyProb&quot;:100,&quot;value&quot;:&quot;P&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:93,&quot;y&quot;:26},{&quot;x&quot;:93,&quot;y&quot;:33},{&quot;x&quot;:87,&quot;y&quot;:33},{&quot;x&quot;:87,&quot;y&quot;:26}],&quot;valueProb&quot;:100},{&quot;key&quot;:&quot;countryCode&quot;,&quot;keyProb&quot;:92,&quot;value&quot;:&quot;CHN&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:143,&quot;y&quot;:26},{&quot;x&quot;:143,&quot;y&quot;:33},{&quot;x&quot;:126,&quot;y&quot;:33},{&quot;x&quot;:126,&quot;y&quot;:26}],&quot;valueProb&quot;:92},{&quot;key&quot;:&quot;passportNumber&quot;,&quot;keyProb&quot;:100,&quot;value&quot;:&quot;E90000082&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:173,&quot;y&quot;:29},{&quot;x&quot;:230,&quot;y&quot;:28},{&quot;x&quot;:230,&quot;y&quot;:35},{&quot;x&quot;:174,&quot;y&quot;:37}],&quot;valueProb&quot;:100},{&quot;key&quot;:&quot;nameEn&quot;,&quot;keyProb&quot;:87,&quot;value&quot;:&quot;,ZHENGJIANGANGUX&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:88,&quot;y&quot;:55},{&quot;x&quot;:89,&quot;y&quot;:48},{&quot;x&quot;:166,&quot;y&quot;:49},{&quot;x&quot;:166,&quot;y&quot;:57}],&quot;valueProb&quot;:87},{&quot;key&quot;:&quot;name&quot;,&quot;keyProb&quot;:100,&quot;value&quot;:&quot;&quot;,&quot;valueProb&quot;:100},{&quot;key&quot;:&quot;sex&quot;,&quot;keyProb&quot;:99,&quot;value&quot;:&quot;3.7F&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:103,&quot;y&quot;:67},{&quot;x&quot;:103,&quot;y&quot;:74},{&quot;x&quot;:87,&quot;y&quot;:74},{&quot;x&quot;:87,&quot;y&quot;:67}],&quot;valueProb&quot;:99},{&quot;key&quot;:&quot;birthPlace&quot;,&quot;keyProb&quot;:98,&quot;value&quot;:&quot;北京/BEIJIHG&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:133,&quot;y&quot;:83},{&quot;x&quot;:133,&quot;y&quot;:91},{&quot;x&quot;:87,&quot;y&quot;:91},{&quot;x&quot;:87,&quot;y&quot;:83}],&quot;valueProb&quot;:98},{&quot;key&quot;:&quot;nationality&quot;,&quot;keyProb&quot;:100,&quot;value&quot;:&quot;&quot;,&quot;valueProb&quot;:100},{&quot;key&quot;:&quot;issuePlace&quot;,&quot;keyProb&quot;:99,&quot;value&quot;:&quot;山东/SHANDON&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:136,&quot;y&quot;:100},{&quot;x&quot;:136,&quot;y&quot;:108},{&quot;x&quot;:88,&quot;y&quot;:108},{&quot;x&quot;:88,&quot;y&quot;:100}],&quot;valueProb&quot;:99},{&quot;key&quot;:&quot;issueAuthority&quot;,&quot;keyProb&quot;:79,&quot;value&quot;:&quot;公安部出入境管理局&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:87,&quot;y&quot;:118},{&quot;x&quot;:142,&quot;y&quot;:118},{&quot;x&quot;:142,&quot;y&quot;:125},{&quot;x&quot;:87,&quot;y&quot;:125}],&quot;valueProb&quot;:79},{&quot;key&quot;:&quot;mrzLine1&quot;,&quot;keyProb&quot;:100,&quot;value&quot;:&quot;POCHNZHENGJIAN&lt;&lt;YANGBEN&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&lt;&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:12,&quot;y&quot;:153},{&quot;x&quot;:252,&quot;y&quot;:152},{&quot;x&quot;:252,&quot;y&quot;:159},{&quot;x&quot;:12,&quot;y&quot;:161}],&quot;valueProb&quot;:100},{&quot;key&quot;:&quot;mrzLine2&quot;,&quot;keyProb&quot;:99,&quot;value&quot;:&quot;E900000821CHN8108038F2110189NGKELMPONBPJB978&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:11,&quot;y&quot;:166},{&quot;x&quot;:253,&quot;y&quot;:165},{&quot;x&quot;:253,&quot;y&quot;:173},{&quot;x&quot;:12,&quot;y&quot;:175}],&quot;valueProb&quot;:99},{&quot;key&quot;:&quot;validToDate&quot;,&quot;keyProb&quot;:60,&quot;value&quot;:&quot;2921.DCF.3B&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:170,&quot;y&quot;:107},{&quot;x&quot;:171,&quot;y&quot;:99},{&quot;x&quot;:226,&quot;y&quot;:101},{&quot;x&quot;:225,&quot;y&quot;:108}],&quot;valueProb&quot;:86},{&quot;key&quot;:&quot;birthDate&quot;,&quot;keyProb&quot;:100,&quot;value&quot;:&quot;08.1981&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:209,&quot;y&quot;:67},{&quot;x&quot;:209,&quot;y&quot;:74},{&quot;x&quot;:181,&quot;y&quot;:74},{&quot;x&quot;:181,&quot;y&quot;:67}],&quot;valueProb&quot;:99},{&quot;key&quot;:&quot;issueDate&quot;,&quot;keyProb&quot;:82,&quot;value&quot;:&quot;91.1010.19&quot;,&quot;valuePos&quot;:[{&quot;x&quot;:226,&quot;y&quot;:83},{&quot;x&quot;:226,&quot;y&quot;:90},{&quot;x&quot;:170,&quot;y&quot;:90},{&quot;x&quot;:170,&quot;y&quot;:83}],&quot;valueProb&quot;:84}],&quot;sliceRect&quot;:{&quot;x0&quot;:1,&quot;y0&quot;:1,&quot;x1&quot;:269,&quot;y1&quot;:1,&quot;x2&quot;:269,&quot;y2&quot;:184,&quot;x3&quot;:1,&quot;y3&quot;:183},&quot;width&quot;:271}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43A29C77-405E-4CC0-BC55-EE694AD00655</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
