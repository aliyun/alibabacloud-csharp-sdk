// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModelServiceResponseBody : TeaModel {
        [NameInMap("AiNodes")]
        [Validation(Required=false)]
        public List<string> AiNodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cx/Y57lTNf*********</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qwen3-Embedding-8B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> ModelParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ms-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("ModelServiceId")]
        [Validation(Required=false)]
        public string ModelServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://ms-xxxxxxx.xxxx.rds.aliyuncs.com">http://ms-xxxxxxx.xxxx.rds.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("PrivateConnectUrl")]
        [Validation(Required=false)]
        public string PrivateConnectUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://ms-xxxxxxx-o.xxxx.rds.aliyuncs.com">http://ms-xxxxxxx-o.xxxx.rds.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("PublicConnectUrl")]
        [Validation(Required=false)]
        public string PublicConnectUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public string SecurityIpList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>deployming</description></item>
        /// <item><description>active</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
