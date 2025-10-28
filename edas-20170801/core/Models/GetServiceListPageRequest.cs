// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceListPageRequest : TeaModel {
        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou:doc-test</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The source of the data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>agent</c>: Use this value if you use the service query feature of the latest version to pass the query result.</description></item>
        /// <item><description><c>registry</c>: Use this value if you use the service query feature of the earlier version to pass the query result.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Agent</para>
        /// </summary>
        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from Page 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>app</c>: searches by application.</description></item>
        /// <item><description><c>service</c>: searches by service.</description></item>
        /// <item><description><c>providerIp</c>: searches by IP address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>App</para>
        /// </summary>
        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>The keyword used for the search.</para>
        /// <list type="bullet">
        /// <item><description>Set this parameter to the ID of the application if you set the searchType parameter to app.``</description></item>
        /// <item><description>Set this parameter to the name of the service if you set the serachType parameter to service.``</description></item>
        /// <item><description>Set this parameter to the IP address of the application if you set the searchType parameter to providerIp.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.edas.HelloService</para>
        /// </summary>
        [NameInMap("searchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        /// <summary>
        /// <para>The type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>dubbo</c></description></item>
        /// <item><description><c>springCloud</c></description></item>
        /// <item><description><c>hsf</c></description></item>
        /// <item><description><c>istio</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SpringCloud</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>Specifies the provider side or the consumer side. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>provider</description></item>
        /// <item><description>consumer</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>provider</para>
        /// </summary>
        [NameInMap("side")]
        [Validation(Required=false)]
        public string Side { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
