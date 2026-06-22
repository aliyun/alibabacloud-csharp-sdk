// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of honeypot data.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotResponseBodyList> List { get; set; }
        public class ListHoneypotResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The name of the honeypot management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0804-pre</para>
            /// </summary>
            [NameInMap("ControlNodeName")]
            [Validation(Required=false)]
            public string ControlNodeName { get; set; }

            /// <summary>
            /// <para>The honeypot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76c2a1c72ef259777d96d55a7834e5f5d98f85666c49f76ad9caa447d8b7****</para>
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

            /// <summary>
            /// <para>The display name of the honeypot image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MongoDB</para>
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the honeypot image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:eca5ced3757e46c24701e9ced4e652f2d730262d5685a4e001da22c4fb418fd4</para>
            /// </summary>
            [NameInMap("HoneypotImageId")]
            [Validation(Required=false)]
            public string HoneypotImageId { get; set; }

            /// <summary>
            /// <para>The name of the honeypot image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp_proxy</para>
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// <para>The name of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mx-rouyi</para>
            /// </summary>
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            /// <summary>
            /// <para>The ID of the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c94eff5b-ea48-4805-8b7f-e04d3509b117</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the custom honeypot parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a882e590-b87b-45a6-87b9-d0a3e5a0****</para>
            /// </summary>
            [NameInMap("PresetId")]
            [Validation(Required=false)]
            public string PresetId { get; set; }

            /// <summary>
            /// <para>The status of the honeypot.</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public List<string> State { get; set; }

        }

        /// <summary>
        /// <para>The detailed information about the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries to return per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C80AFF1F-CC20-502C-A4D4-F5433E529B69</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
