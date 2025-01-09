// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafManagedRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The attack type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL injection</description></item>
        /// <item><description>Cross-site scripting</description></item>
        /// <item><description>Code execution</description></item>
        /// <item><description>CRLF</description></item>
        /// <item><description>Local file inclusion</description></item>
        /// <item><description>Remote file inclusion</description></item>
        /// <item><description>webshell</description></item>
        /// <item><description>Cross-site request forgery</description></item>
        /// <item><description>Others</description></item>
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
        /// <para>The ID of the WAF rule, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850237.html">ListWafRules</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
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

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The query conditions.</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgsShrink { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
