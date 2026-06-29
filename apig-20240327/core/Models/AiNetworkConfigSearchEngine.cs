// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiNetworkConfigSearchEngine : TeaModel {
        /// <summary>
        /// <para>The API key of the search engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>Quark-specific: the content mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>summary</para>
        /// </summary>
        [NameInMap("contentMode")]
        [Validation(Required=false)]
        public string ContentMode { get; set; }

        /// <summary>
        /// <para>The number of results returned per search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The endpoint of the search engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cloud-iqs.aliyuncs.com">https://cloud-iqs.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>Quark-specific: the industry filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>互联网</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The search engine-specific parameters in key-value pair format.</para>
        /// </summary>
        [NameInMap("optionArgs")]
        [Validation(Required=false)]
        public Dictionary<string, string> OptionArgs { get; set; }

        /// <summary>
        /// <para>The offset of search results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

        /// <summary>
        /// <para>Quark-specific: the time range filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7d</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

        /// <summary>
        /// <para>The API call timeout period, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("timeoutMillisecond")]
        [Validation(Required=false)]
        public int? TimeoutMillisecond { get; set; }

        /// <summary>
        /// <para>The search engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyunQuark</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
