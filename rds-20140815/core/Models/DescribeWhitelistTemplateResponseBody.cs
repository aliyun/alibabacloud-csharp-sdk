// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeWhitelistTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: success</description></item>
        /// <item><description><b>400</b>: client error</description></item>
        /// <item><description><b>401</b>: identity authentication failed</description></item>
        /// <item><description><b>404</b>: request page not found</description></item>
        /// <item><description><b>500</b>: server error</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWhitelistTemplateResponseBodyData Data { get; set; }
        public class DescribeWhitelistTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the IP whitelist template.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public DescribeWhitelistTemplateResponseBodyDataTemplate Template { get; set; }
            public class DescribeWhitelistTemplateResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The primary key of the data table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1013</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The IP addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.X.X,2.3.X.X</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public string Ips { get; set; }

                /// <summary>
                /// <para>The ID of the whitelist template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>424</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the IP whitelist template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>template_123</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public int? UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: success</description></item>
        /// <item><description><b>400</b>: client error</description></item>
        /// <item><description><b>500</b>: server error</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED169A3E-1657-4104-82AB-24EA8CD0DB75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
