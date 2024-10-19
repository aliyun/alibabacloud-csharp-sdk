// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisRequest : TeaModel {
        /// <summary>
        /// <para>The API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f68c19ee3bd1478fb58aa05ce8ae9b5a</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The HTTP method of the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("ApiMethod")]
        [Validation(Required=false)]
        public string ApiMethod { get; set; }

        /// <summary>
        /// <para>The API name. The name is used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weather</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The request path of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/illegal/query</para>
        /// </summary>
        [NameInMap("ApiPath")]
        [Validation(Required=false)]
        public string ApiPath { get; set; }

        /// <summary>
        /// <para>The category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1553414085247362</para>
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable tag verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTagAuth")]
        [Validation(Required=false)]
        public bool? EnableTagAuth { get; set; }

        /// <summary>
        /// <para>The API group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4a4d2de657548a2bd485d5d4df42b4a</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The environment in which you want to perform this operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RELEASE</b>: the production environment</description></item>
        /// <item><description><b>PRE</b>: the staging environment</description></item>
        /// <item><description><b>TEST</b>: the test environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// <para>The tags of objects that match the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Key， Value</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeApisRequestTag> Tag { get; set; }
        public class DescribeApisRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to filter unpublished APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UnDeployed")]
        [Validation(Required=false)]
        public bool? UnDeployed { get; set; }

        /// <summary>
        /// <para>Specifies whether the API is public. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC</b>: The API is public. If you publish the definition of a public API to the production environment, the definition is displayed on the APIs page for all users.</description></item>
        /// <item><description><b>PRIVATE</b>: The API is private. If you publish an API group that contains a private API in Alibaba Cloud Marketplace, the API is not displayed in Alibaba Cloud Marketplace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
