// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListModelServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>Model services.</para>
        /// </summary>
        [NameInMap("ModelServices")]
        [Validation(Required=false)]
        public List<ListModelServicesResponseBodyModelServices> ModelServices { get; set; }
        public class ListModelServicesResponseBodyModelServices : TeaModel {
            /// <summary>
            /// <para>A list of AI nodes for model deployment.</para>
            /// </summary>
            [NameInMap("AiNodes")]
            [Validation(Required=false)]
            public List<string> AiNodes { get; set; }

            /// <summary>
            /// <para>The API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mI3F7B18vgfqJjUtWmgITw==</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-28T02:18:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sambert-zhiying-v1</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>Model service parameters (not available).</para>
            /// </summary>
            [NameInMap("ModelParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> ModelParams { get; set; }

            /// <summary>
            /// <para>Model service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mx-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("ModelServiceId")]
            [Validation(Required=false)]
            public string ModelServiceId { get; set; }

            /// <summary>
            /// <para>Private Endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ms-xxxxxxx.xxxx.rds.aliyuncs.com">http://ms-xxxxxxx.xxxx.rds.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("PrivateConnUrl")]
            [Validation(Required=false)]
            public string PrivateConnUrl { get; set; }

            /// <summary>
            /// <para>Public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ms-xxxxxxx-o.xxxx.rds.aliyuncs.com">http://ms-xxxxxxx-o.xxxx.rds.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("PublicConnUrl")]
            [Validation(Required=false)]
            public string PublicConnUrl { get; set; }

            /// <summary>
            /// <para>The IP addresses listed in the whitelist. Up to 1,000 IP addresses are contained in a whitelist and separated by commas (,). The IP addresses must use one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description>0.0.0.0/0</description></item>
            /// <item><description>10.23.12.24(IP)</description></item>
            /// <item><description>10.23.12.24/24 (This is a CIDR block. The value<c>/24</c>indicates the network prefix length, which must be an integer and in the range of <c>[1,32]</c>.)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The status of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>fail</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
