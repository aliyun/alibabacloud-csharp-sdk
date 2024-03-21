// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the custom WAF rule group.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the WAF rule group.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number of the page returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of the rule.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafGroupResponseBodyRules> Rules { get; set; }
        public class DescribeDcdnWafGroupResponseBodyRules : TeaModel {
            /// <summary>
            /// The type of the application. Valid values:
            /// 
            /// *   **0**: Common
            /// *   **1**: WordPress
            /// *   **2**: DedeCMS
            /// *   **3**: Discuz
            /// *   **4**: PHP CMS
            /// *   **5**: ECShop
            /// *   **6**: ShopEX
            /// *   **7**: Drupal
            /// *   **8**: Joomla
            /// *   **9**: MetInfo
            /// *   **10**: Struts2
            /// *   **11**: Spring Boot
            /// *   **12**: JBoss
            /// *   **13**: WebLogic
            /// *   **14**: WebSphere
            /// *   **15**: Tomcat
            /// *   **16**: Elastic Search
            /// *   **18**: ThinkPHP
            /// *   **19**: Fastjson
            /// *   **20**: ImageMagick
            /// *   **21**: PHPWind
            /// *   **22**: phpMyAdmin
            /// *   **23**: Resin
            /// *   **24**: IIS
            /// *   **99**: Others
            /// </summary>
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public int? ApplicationType { get; set; }

            /// <summary>
            /// The Common Vulnerabilities and Exposures (CVE) ID of the related vulnerability.
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// The CVE link.
            /// </summary>
            [NameInMap("CveUrl")]
            [Validation(Required=false)]
            public string CveUrl { get; set; }

            /// <summary>
            /// The description of the WAF rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the rule was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the custom WAF rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the WAF rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Protection type Valid values:
            /// 
            /// *   **11**: SQL injection
            /// *   **12**: cross-site scripting (XSS)
            /// *   **13**: code execution
            /// *   **14**: carriage return line feeds (CRLF)
            /// *   **15**: local file inclusion
            /// *   **16**: remote file inclusion
            /// *   **17**: webshells
            /// *   **19**: cross-site request forgery
            /// *   **20**: others
            /// *   **21**: SEMA
            /// </summary>
            [NameInMap("ProtectionType")]
            [Validation(Required=false)]
            public int? ProtectionType { get; set; }

            /// <summary>
            /// The risk level of the resources that do not comply with the managed rule. Valid values:
            /// 
            /// *   **1**: high risk
            /// *   **2**: medium risk
            /// *   **3**: low risk
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// Indicates whether to enable subscription. Valid values:
        /// 
        /// *   **on:**
        /// *   **off**
        /// </summary>
        [NameInMap("Subscribe")]
        [Validation(Required=false)]
        public string Subscribe { get; set; }

        /// <summary>
        /// The ID of the template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// The total number of rules that are filtered out.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
