// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAllWhitelistTemplateResponseBody : TeaModel {
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
        public DescribeAllWhitelistTemplateResponseBodyData Data { get; set; }
        public class DescribeAllWhitelistTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrPageNumbers")]
            [Validation(Required=false)]
            public int? CurrPageNumbers { get; set; }

            /// <summary>
            /// <para>Indicates whether there is a next page of data that meets the conditions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <para>Indicates whether there is a previous page of data that meets the conditions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasPrev")]
            [Validation(Required=false)]
            public bool? HasPrev { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }

            /// <summary>
            /// <para>The whitelist template information returned by page.</para>
            /// </summary>
            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<DescribeAllWhitelistTemplateResponseBodyDataTemplates> Templates { get; set; }
            public class DescribeAllWhitelistTemplateResponseBodyDataTemplates : TeaModel {
                /// <summary>
                /// <para>The primary key of the data table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The IP address list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12.2.X.X,10.0.X.X</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public string Ips { get; set; }

                /// <summary>
                /// <para>The whitelist template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>412</para>
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
                /// <para>168****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public int? UserId { get; set; }

            }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalPageNumbers")]
            [Validation(Required=false)]
            public int? TotalPageNumbers { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>402</para>
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public int? TotalRecords { get; set; }

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
        /// <para>16C62438-491B-5C02-9B49-BA924A1372A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
