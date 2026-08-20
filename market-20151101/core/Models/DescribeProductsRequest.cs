// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProductsRequest : TeaModel {
        /// <summary>
        /// <para>The list of filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeProductsRequestFilter> Filter { get; set; }
        public class DescribeProductsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The category of the search tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>sort: the sorting method</description></item>
            /// <item><description>categoryId: the category ID</description></item>
            /// <item><description>productType: the product type</description></item>
            /// <item><description>aliyunUid: the Alibaba Cloud account ID of the service provider that owns the product.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>categoryId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the search label:</para>
            /// <list type="bullet">
            /// <item><description><para>sort</para>
            /// <list type="bullet">
            /// <item><description>user_count-desc: number of transactions in the last 180 days</description></item>
            /// <item><description>created_on-desc: creation time</description></item>
            /// <item><description>price-desc: price</description></item>
            /// <item><description>score-desc: rating</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>categoryId </para>
            /// <list type="bullet">
            /// <item><description>Software Marketplace  53366009<list type="bullet">
            /// <item><description>Runtime Environment  53448001</description></item>
            /// </list>
            /// <list type="bullet">
            /// <item><description>Management &amp; Monitoring  53690006</description></item>
            /// <item><description>Website Building System  53616009</description></item>
            /// <item><description>Application Development  55530001</description></item>
            /// <item><description>Database  56024006</description></item>
            /// <item><description>Server Software  56014009</description></item>
            /// <item><description>Network Feature Software  56368007</description></item>
            /// <item><description>Operating System  57742013</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Service Marketplace  52734001<list type="bullet">
            /// <item><description>Data Migration  52738004</description></item>
            /// <item><description>Environment Configuration  52746001</description></item>
            /// <item><description>Troubleshooting  52740002</description></item>
            /// <item><description>Security O&amp;M  52732002</description></item>
            /// <item><description>Custom Development  56082003</description></item>
            /// <item><description>Training &amp; Certification  57252001</description></item>
            /// <item><description>Dedicated Line Access  57392001</description></item>
            /// <item><description>Enterprise Services  56838014</description></item>
            /// <item><description>Security Services  57004003</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Website Building Marketplace  52738001<list type="bullet">
            /// <item><description>Enterprise Display  52738005</description></item>
            /// <item><description>E-commerce  52750001</description></item>
            /// <item><description>Mobile Website  52752001</description></item>
            /// <item><description>Design  52732003</description></item>
            /// <item><description>Information Portal  52744002</description></item>
            /// <item><description>After-sales Service  52744003</description></item>
            /// <item><description>Community Forum  55586021</description></item>
            /// <item><description>Mobile Marketing  55514022</description></item>
            /// <item><description>Template Website  56598032</description></item>
            /// <item><description>Website Hosting  57342011</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Cloud Security Marketplace  56764045<list type="bullet">
            /// <item><description>Host Security  56832023</description></item>
            /// <item><description>Application Security  56846020</description></item>
            /// <item><description>Data Security  56824015</description></item>
            /// <item><description>Security Management  56830014</description></item>
            /// <item><description>Network Security  56820014</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Enterprise Applications  56832009<list type="bullet">
            /// <item><description>Office Management  56778013</description></item>
            /// <item><description>Financial Management  56764034</description></item>
            /// <item><description>HR Management  56780006</description></item>
            /// <item><description>Sales Management  56842010</description></item>
            /// <item><description>Advertising &amp; Marketing  56842011</description></item>
            /// <item><description>Foreign Trade  56790007</description></item>
            /// <item><description>Cloud Communications  57602001</description></item>
            /// <item><description>Supply Chain Management  57604001</description></item>
            /// <item><description>Data Services  57606001</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Solutions  56848023<list type="bullet">
            /// <item><description>E-commerce  56848024</description></item>
            /// <item><description>Finance  56820017</description></item>
            /// <item><description>Logistics  56776025</description></item>
            /// <item><description>Government  56842031</description></item>
            /// <item><description>Multimedia  56784018</description></item>
            /// <item><description>IoT  56794026</description></item>
            /// <item><description>Big Data  56792022</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>API Marketplace  56956004<list type="bullet">
            /// <item><description>E-commerce  56928004</description></item>
            /// <item><description>Finance &amp; Investment  57000002</description></item>
            /// <item><description>Transportation &amp; Geography  57002002</description></item>
            /// <item><description>Enterprise Management  56928005</description></item>
            /// <item><description>Public Affairs  57002003</description></item>
            /// <item><description>Meteorology &amp; Water Resources  57096001</description></item>
            /// <item><description>Artificial Intelligence  57124001</description></item>
            /// <item><description>Lifestyle Services  57126001</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>IoT Marketplace  201194001<list type="bullet">
            /// <item><description>Integrated Systems  201196001</description></item>
            /// <item><description>Smart Hardware  201198001</description></item>
            /// <item><description>Modules  201200001</description></item>
            /// <item><description>Sensors  201192002</description></item>
            /// <item><description>Chips  201202001</description></item>
            /// <item><description>IoT Applications  201196002</description></item>
            /// <item><description>IoT Services  201196003</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Data Intelligence  201204005<list type="bullet">
            /// <item><description>Data Analytics &amp; Visualization  201190008</description></item>
            /// <item><description>Public Opinion Analysis  201198004</description></item>
            /// <item><description>E-commerce &amp; Marketing  201202006</description></item>
            /// <item><description>Artificial Intelligence  201204006</description></item>
            /// <item><description>Meteorology &amp; Transportation  201214006</description></item>
            /// <item><description>Finance &amp; Accounting  201208013</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>productType:</para>
            /// <list type="bullet">
            /// <item><description>APP: application</description></item>
            /// <item><description>SERVICE: service</description></item>
            /// <item><description>MIRROR: image</description></item>
            /// <item><description>DOWNLOAD: download</description></item>
            /// <item><description>API_SERVICE: API.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>53366009</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of products to display per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>镜像</para>
        /// </summary>
        [NameInMap("SearchTerm")]
        [Validation(Required=false)]
        public string SearchTerm { get; set; }

    }

}
