// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetTurnServerListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A list of front-end access point servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;region&quot;:&quot;hangzhou&quot;,
        ///         &quot;name&quot;:&quot;杭州&quot;,
        ///         &quot;domain&quot;:&quot;turn-hz-ecs.ccc.aliyuncs.com&quot;,
        ///         &quot;cidr&quot;:&quot;172.31.XX.XX/28&quot;
        ///     },
        ///     {
        ///         &quot;region&quot;:&quot;qingdao&quot;,
        ///         &quot;name&quot;:&quot;青岛&quot;,
        ///         &quot;domain&quot;:&quot;turn-qd-ecs.ccc.aliyuncs.com&quot;,
        ///         &quot;cidr&quot;:&quot;172.31.XX.XX/28&quot;
        ///     },
        ///     {
        ///         &quot;region&quot;:&quot;shanghai&quot;,
        ///         &quot;name&quot;:&quot;上海&quot;,
        ///         &quot;domain&quot;:&quot;turn-sh-ecs.ccc.aliyuncs.com&quot;,
        ///         &quot;cidr&quot;:&quot;172.31.XX.XX/28&quot;
        ///     },
        ///     {
        ///         &quot;region&quot;:&quot;chengdu&quot;,
        ///         &quot;name&quot;:&quot;成都&quot;,
        ///         &quot;domain&quot;:&quot;turn-cd-ecs.ccc.aliyuncs.com&quot;,
        ///         &quot;cidr&quot;:&quot;172.31.XX.XX/28&quot;
        ///     },
        ///     {
        ///         &quot;region&quot;:&quot;beijing&quot;,
        ///         &quot;name&quot;:&quot;北京&quot;,
        ///         &quot;domain&quot;:&quot;turn-bj-ecs.ccc.aliyuncs.com&quot;,
        ///         &quot;cidr&quot;:&quot;172.31.XX.XX/28&quot;
        ///     },
        ///     {
        ///         &quot;region&quot;:&quot;huanan&quot;,
        ///         &quot;name&quot;:&quot;深圳&quot;,
        ///         &quot;domain&quot;:&quot;turn-sz-ecs.ccc.aliyuncs.com&quot;,
        ///         &quot;cidr&quot;:&quot;172.31.XX.XX/28&quot;
        ///     },
        ///     {
        ///         &quot;region&quot;:&quot;zhangbei&quot;,
        ///         &quot;name&quot;:&quot;张北&quot;,
        ///         &quot;domain&quot;:&quot;turn-zb-ecs.ccc.aliyuncs.com&quot;,
        ///         &quot;cidr&quot;:&quot;172.31.XX.XX/28&quot;
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

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
        /// <para>The response message.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
