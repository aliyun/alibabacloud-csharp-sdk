// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListModelServicesResponseBody : TeaModel {
        [NameInMap("ModelServices")]
        [Validation(Required=false)]
        public List<ListModelServicesResponseBodyModelServices> ModelServices { get; set; }
        public class ListModelServicesResponseBodyModelServices : TeaModel {
            [NameInMap("AiNodes")]
            [Validation(Required=false)]
            public List<string> AiNodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mI3F7B18vgfqJjUtWmgITw==</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-28T02:18:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sambert-zhiying-v1</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            [NameInMap("ModelParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> ModelParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mx-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("ModelServiceId")]
            [Validation(Required=false)]
            public string ModelServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://ms-xxxxxxx.xxxx.rds.aliyuncs.com">http://ms-xxxxxxx.xxxx.rds.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("PrivateConnUrl")]
            [Validation(Required=false)]
            public string PrivateConnUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://ms-xxxxxxx-o.xxxx.rds.aliyuncs.com">http://ms-xxxxxxx-o.xxxx.rds.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("PublicConnUrl")]
            [Validation(Required=false)]
            public string PublicConnUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
