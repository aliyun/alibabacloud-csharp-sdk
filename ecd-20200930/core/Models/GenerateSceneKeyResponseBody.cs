// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GenerateSceneKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The Agent Gateway endpoint, which includes the cluster offset mapping port. This parameter is returned only for desktop scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-agent-cn-hangzhou.wuyinggw.com:18008</para>
        /// </summary>
        [NameInMap("BaseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>The expiration time of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-13T12:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The scenario access key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scenario access URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://gw-example.cn-hangzhou.aigclinks.com:18008">https://gw-example.cn-hangzhou.aigclinks.com:18008</a></para>
        /// </summary>
        [NameInMap("SceneUrl")]
        [Validation(Required=false)]
        public string SceneUrl { get; set; }

    }

}
