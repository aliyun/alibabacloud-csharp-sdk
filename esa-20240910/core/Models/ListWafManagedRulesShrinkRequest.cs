// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafManagedRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Attack type of the vulnerability protection event. Values:</para>
        /// <list type="bullet">
        /// <item><description>SQL injection</description></item>
        /// <item><description>Cross-site scripting</description></item>
        /// <item><description>Code execution</description></item>
        /// <item><description>CRLF</description></item>
        /// <item><description>Local file inclusion</description></item>
        /// <item><description>Remote file inclusion</description></item>
        /// <item><description>Webshell</description></item>
        /// <item><description>Cross-site request forgery</description></item>
        /// <item><description>Other</description></item>
        /// <item><description>SEMA</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public int? AttackType { get; set; }

        /// <summary>
        /// <para>ID of the WAF rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Language type, which will be used to return the response. Value range:</para>
        /// <list type="bullet">
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("ManagedRuleset")]
        [Validation(Required=false)]
        public string ManagedRulesetShrink { get; set; }

        /// <summary>
        /// <para>Query page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Query page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public int? ProtectionLevel { get; set; }

        /// <summary>
        /// <para>Query conditions.</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgsShrink { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
