// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the custom WAF rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1012</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the WAF rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the rule.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafGroupResponseBodyRules> Rules { get; set; }
        public class DescribeDcdnWafGroupResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Common</description></item>
            /// <item><description><b>1</b>: WordPress</description></item>
            /// <item><description><b>2</b>: DedeCMS</description></item>
            /// <item><description><b>3</b>: Discuz</description></item>
            /// <item><description><b>4</b>: PHP CMS</description></item>
            /// <item><description><b>5</b>: ECShop</description></item>
            /// <item><description><b>6</b>: ShopEX</description></item>
            /// <item><description><b>7</b>: Drupal</description></item>
            /// <item><description><b>8</b>: Joomla</description></item>
            /// <item><description><b>9</b>: MetInfo</description></item>
            /// <item><description><b>10</b>: Struts2</description></item>
            /// <item><description><b>11</b>: Spring Boot</description></item>
            /// <item><description><b>12</b>: JBoss</description></item>
            /// <item><description><b>13</b>: WebLogic</description></item>
            /// <item><description><b>14</b>: WebSphere</description></item>
            /// <item><description><b>15</b>: Tomcat</description></item>
            /// <item><description><b>16</b>: Elastic Search</description></item>
            /// <item><description><b>18</b>: ThinkPHP</description></item>
            /// <item><description><b>19</b>: Fastjson</description></item>
            /// <item><description><b>20</b>: ImageMagick</description></item>
            /// <item><description><b>21</b>: PHPWind</description></item>
            /// <item><description><b>22</b>: phpMyAdmin</description></item>
            /// <item><description><b>23</b>: Resin</description></item>
            /// <item><description><b>24</b>: IIS</description></item>
            /// <item><description><b>99</b>: Others</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public int? ApplicationType { get; set; }

            /// <summary>
            /// <para>The Common Vulnerabilities and Exposures (CVE) ID of the related vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2021-22945</para>
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The CVE link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://nxx.nxxx.gov/vuln/detail/CVE-2022-XXXX">https://nxx.nxxx.gov/vuln/detail/CVE-2022-XXXX</a></para>
            /// </summary>
            [NameInMap("CveUrl")]
            [Validation(Required=false)]
            public string CveUrl { get; set; }

            /// <summary>
            /// <para>The description of the WAF rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the rule was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-29T17:08:45Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the custom WAF rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the WAF rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Protection type Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>11</b>: SQL injection</description></item>
            /// <item><description><b>12</b>: cross-site scripting (XSS)</description></item>
            /// <item><description><b>13</b>: code execution</description></item>
            /// <item><description><b>14</b>: carriage return line feeds (CRLF)</description></item>
            /// <item><description><b>15</b>: local file inclusion</description></item>
            /// <item><description><b>16</b>: remote file inclusion</description></item>
            /// <item><description><b>17</b>: webshells</description></item>
            /// <item><description><b>19</b>: cross-site request forgery</description></item>
            /// <item><description><b>20</b>: others</description></item>
            /// <item><description><b>21</b>: SEMA</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("ProtectionType")]
            [Validation(Required=false)]
            public int? ProtectionType { get; set; }

            /// <summary>
            /// <para>The risk level of the resources that do not comply with the managed rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: high risk</description></item>
            /// <item><description><b>2</b>: medium risk</description></item>
            /// <item><description><b>3</b>: low risk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether to enable subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on:</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Subscribe")]
        [Validation(Required=false)]
        public string Subscribe { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1012</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The total number of rules that are filtered out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
