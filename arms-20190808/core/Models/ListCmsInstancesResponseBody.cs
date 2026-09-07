// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListCmsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCmsInstancesResponseBodyData Data { get; set; }
        public class ListCmsInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether tag collection for the cloud product is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTag")]
            [Validation(Required=false)]
            public bool? EnableTag { get; set; }

            /// <summary>
            /// <para>The list of cloud products.</para>
            /// </summary>
            [NameInMap("Products")]
            [Validation(Required=false)]
            public List<ListCmsInstancesResponseBodyDataProducts> Products { get; set; }
            public class ListCmsInstancesResponseBodyDataProducts : TeaModel {
                /// <summary>
                /// <para>The product description.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Descr")]
                [Validation(Required=false)]
                public string Descr { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20210</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloudserver</para>
                /// </summary>
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>The name of the integrated cloud product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hologres</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>face</para>
                /// </summary>
                [NameInMap("Prod")]
                [Validation(Required=false)]
                public string Prod { get; set; }

                /// <summary>
                /// <para>The event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arms</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The integration status of the product.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Integrated.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Not integrated.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The creation timestamp of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1647852021000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The product type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOLOGRES</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The complete URL of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://g.console.aliyun.com/d/1098370038733503-35894-565/cms-hologres?orgId%5C%5Cu003d9%5C%5Cu0026refresh%5C%5Cu003d60s">https://g.console.aliyun.com/d/1098370038733503-35894-565/cms-hologres?orgId\\u003d9\\u0026refresh\\u003d60s</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7A04B0D-E2CA-59BB-8A9D-D5D349C22BF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
