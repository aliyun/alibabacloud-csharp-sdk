// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListApiPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>API plugin list</para>
        /// </summary>
        [NameInMap("ApiPlugins")]
        [Validation(Required=false)]
        public List<ListApiPluginsResponseBodyApiPlugins> ApiPlugins { get; set; }
        public class ListApiPluginsResponseBodyApiPlugins : TeaModel {
            /// <summary>
            /// <para>Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这个插件是用来xxx.....</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Draft configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;description&quot;: &quot;测试-2&quot;,
            ///     &quot;functionMeta&quot;: {
            ///         &quot;failoverRegionWeight&quot;: 0.5,
            ///         &quot;functionMetaId&quot;: &quot;a9127136087e4172b31b8f400430d63b&quot;,
            ///         &quot;functionName&quot;: &quot;yongyu-stream-2&quot;,
            ///         &quot;regionId&quot;: &quot;cn-hangzhou&quot;
            ///     },
            ///     &quot;inputParams&quot;: [{
            ///         &quot;debugValue&quot;: &quot;1112&quot;,
            ///         &quot;description&quot;: &quot;测试&quot;,
            ///         &quot;name&quot;: &quot;test&quot;,
            ///         &quot;required&quot;: false,
            ///         &quot;type&quot;: &quot;String&quot;,
            ///         &quot;valueSource&quot;: &quot;Var&quot;
            ///     }],
            ///     &quot;name&quot;: &quot;测试插件01&quot;,
            ///     &quot;outputParams&quot;: [{
            ///         &quot;description&quot;: &quot;直接返回API结果，并作为提示词输入给模型&quot;,
            ///         &quot;name&quot;: &quot;result&quot;,
            ///         &quot;type&quot;: &quot;String&quot;
            ///     }],
            ///     &quot;timeout&quot;: 5,
            ///     &quot;transitionContent&quot;: &quot;稍等，和您确认下信息。&quot;,
            ///     &quot;type&quot;: &quot;Function&quot;
            /// }</para>
            /// </summary>
            [NameInMap("DraftedConfigJson")]
            [Validation(Required=false)]
            public string DraftedConfigJson { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1666230851000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641891940000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c0e5b5e-a839-4999-8301-2c7d07a1f16f</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Plugin name</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个插件</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Published configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;description&quot;: &quot;发布-2&quot;,
            ///     &quot;functionMeta&quot;: {
            ///         &quot;failoverRegionWeight&quot;: 0.5,
            ///         &quot;functionMetaId&quot;: &quot;c4af5815daaa485bb8118be6b2f14058&quot;,
            ///         &quot;functionName&quot;: &quot;yongyu-stream-2&quot;,
            ///         &quot;regionId&quot;: &quot;cn-hangzhou&quot;
            ///     },
            ///     &quot;inputParams&quot;: [{
            ///         &quot;debugValue&quot;: &quot;111&quot;,
            ///         &quot;description&quot;: &quot;发布&quot;,
            ///         &quot;name&quot;: &quot;test&quot;,
            ///         &quot;required&quot;: false,
            ///         &quot;type&quot;: &quot;String&quot;,
            ///         &quot;valueSource&quot;: &quot;Var&quot;
            ///     }],
            ///     &quot;name&quot;: &quot;发布插件&quot;,
            ///     &quot;outputParams&quot;: [{
            ///         &quot;description&quot;: &quot;直接返回API结果，并作为提示词输入给模型&quot;,
            ///         &quot;name&quot;: &quot;result&quot;,
            ///         &quot;type&quot;: &quot;String&quot;
            ///     }],
            ///     &quot;timeout&quot;: 5,
            ///     &quot;transitionContent&quot;: &quot;稍等，和您确认下信息。&quot;,
            ///     &quot;type&quot;: &quot;Function&quot;
            /// }</para>
            /// </summary>
            [NameInMap("PublishedConfigJson")]
            [Validation(Required=false)]
            public string PublishedConfigJson { get; set; }

            /// <summary>
            /// <para>Status.</para>
            /// <list type="bullet">
            /// <item><description><para>Drafted</para>
            /// </description></item>
            /// <item><description><para>Published</para>
            /// </description></item>
            /// <item><description><para>PublishedAndEdited</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Drafted</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Function</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Unique plugin identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>e1a3c448-20cf-4586-8aa2-4cdca75f7c20</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API prompt message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries displayed per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates success</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of entries</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
