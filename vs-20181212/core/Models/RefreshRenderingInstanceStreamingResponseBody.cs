// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class RefreshRenderingInstanceStreamingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>792fy125-594c-4dde-ab35-9ff8hrf0a86f</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.178.208.22</para>
        /// </summary>
        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-xxx.ecr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
