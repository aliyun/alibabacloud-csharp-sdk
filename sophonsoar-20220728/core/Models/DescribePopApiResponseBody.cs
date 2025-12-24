// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddAssetCleanConfig</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The information about the API.</para>
        /// </summary>
        [NameInMap("OpenApiMetaList")]
        [Validation(Required=false)]
        public List<DescribePopApiResponseBodyOpenApiMetaList> OpenApiMetaList { get; set; }
        public class DescribePopApiResponseBodyOpenApiMetaList : TeaModel {
            /// <summary>
            /// <para>The parameter description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo parameter</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The example value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.xx.xx.xx</para>
            /// </summary>
            [NameInMap("ExampleValue")]
            [Validation(Required=false)]
            public string ExampleValue { get; set; }

            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DescribePopApi</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter is required.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("Style")]
            [Validation(Required=false)]
            public string Style { get; set; }

            /// <summary>
            /// <para>The data type of the parameter field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>string</b></description></item>
            /// <item><description><b>boolean</b></description></item>
            /// <item><description><b>integer</b></description></item>
            /// <item><description><b>long</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The POP code of the Alibaba Cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sas</para>
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A01B0BA-CFC4-5813-9EB0-A5DA15FA95AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-10</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
