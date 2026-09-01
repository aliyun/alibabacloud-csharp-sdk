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
        /// <para>List of API information.</para>
        /// </summary>
        [NameInMap("OpenApiMetaList")]
        [Validation(Required=false)]
        public List<DescribePopApiResponseBodyOpenApiMetaList> OpenApiMetaList { get; set; }
        public class DescribePopApiResponseBodyOpenApiMetaList : TeaModel {
            /// <summary>
            /// <para>The description of the parameter.</para>
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
            /// <item><description><para><b>true</b>: required.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: not required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <para>The serialization method for an array parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>repeatList</b>: An array is serialized in the XXX.N format. Example: Instance.1=i-instance1&amp;\&amp;Instance.2=i-instance2.</para>
            /// </description></item>
            /// <item><description><para><b>simple</b>: An array is serialized as a comma-separated string. Example: i-instance1,i-instance2.</para>
            /// </description></item>
            /// <item><description><para><b>spaceDelimited</b>: An array is serialized as a space-separated string. Example: i-instance1 i-instance2.</para>
            /// </description></item>
            /// <item><description><para><b>pipeDelimited</b>: An array is serialized as a pipe-separated string. Example: i-instance1|i-instance2.</para>
            /// </description></item>
            /// <item><description><para><b>json</b>: An array is serialized in JSON format. Example: [&quot;i-instance1&quot;,&quot;i-instance2&quot;].</para>
            /// </description></item>
            /// <item><description><para><b>flat</b>: An array is serialized in the XXX.N format. Example: Instance.1=i-instance1\&amp;Instance.2=i-instance2.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>json</para>
            /// </summary>
            [NameInMap("Style")]
            [Validation(Required=false)]
            public string Style { get; set; }

            /// <summary>
            /// <para>The data type of the parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>string</b>: a string.</para>
            /// </description></item>
            /// <item><description><para><b>boolean</b>: a Boolean value.</para>
            /// </description></item>
            /// <item><description><para><b>integer</b>: an integer.</para>
            /// </description></item>
            /// <item><description><para><b>long</b>: a long integer.</para>
            /// </description></item>
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
        /// <para>The POP code of the Alibaba Cloud product API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sas</para>
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates this unique ID for each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A01B0BA-<b><b>-5813-</b></b>-A5DA15FA95AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version number of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-10</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
