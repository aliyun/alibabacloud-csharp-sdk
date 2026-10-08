// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeWhitelistTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: Normal.</description></item>
        /// <item><description><b>400</b>: Client fault.</description></item>
        /// <item><description><b>401</b>: Authentication failed.</description></item>
        /// <item><description><b>404</b>: Request page not found.</description></item>
        /// <item><description><b>500</b>: Server fault.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeWhitelistTemplateResponseBodyData Data { get; set; }
        public class DescribeWhitelistTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The whitelist template information.</para>
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
                /// <para>The IP address list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.X.X,2.3.X.X</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public string Ips { get; set; }

                /// <summary>
                /// <para>The whitelist template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>424</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                /// <summary>
                /// <para>The whitelist template name.</para>
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
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: Success.</description></item>
        /// <item><description><b>400</b>: Client error.</description></item>
        /// <item><description><b>500</b>: Server error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
