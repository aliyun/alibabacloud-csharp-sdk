// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessMaliciousFilesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert has been handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: handled</description></item>
        /// <item><description>N: not handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The name of the malicious file to query.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WebShell</para>
        /// </summary>
        [NameInMap("FuzzyMaliciousName")]
        [Validation(Required=false)]
        public string FuzzyMaliciousName { get; set; }

        /// <summary>
        /// <para>The language type for the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The severity levels. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>serious: urgent</description></item>
        /// <item><description>suspicious: suspicious</description></item>
        /// <item><description>remind: reminder.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>remind,suspicious</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

        /// <summary>
        /// <para>The MD5 hash of the malicious file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d836968041f7683b5459****</para>
        /// </summary>
        [NameInMap("MaliciousMd5")]
        [Validation(Required=false)]
        public string MaliciousMd5 { get; set; }

        /// <summary>
        /// <para>The alert type.</para>
        /// <para>If Lang is set to zh, valid values:</para>
        /// <list type="bullet">
        /// <item><description>WebShell: WebShell</description></item>
        /// <item><description>恶意软件: malware</description></item>
        /// <item><description>恶意脚本: malicious script</description></item>
        /// </list>
        /// <para>If Lang is set to en, valid values:</para>
        /// <list type="bullet">
        /// <item><description>WebShell: WebShell</description></item>
        /// <item><description>Malicious Software: malware</description></item>
        /// <item><description>Malicious Script: malicious script.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WebShell</para>
        /// </summary>
        [NameInMap("MaliciousType")]
        [Validation(Required=false)]
        public string MaliciousType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The asset information for the vulnerability query. You can set this parameter to the asset name, public IP address, or private IP address. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The file source.</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

        /// <summary>
        /// <para>The unique identifier of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d2d94e8b-bb25-4744-8004-1e08a53c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
