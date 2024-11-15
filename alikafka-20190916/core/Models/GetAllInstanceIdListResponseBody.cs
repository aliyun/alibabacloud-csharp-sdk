// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAllInstanceIdListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The IDs of instances that are managed by the Alibaba Cloud account in all the regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;cn-shenzhen&quot;: [&quot;alikafka_post-cn-7pp2btvo****&quot;],&quot;us-west-1&quot;: [&quot;alikafka_pre-cn-i7m2lxid****&quot;],&quot;cn-hangzhou&quot;: [&quot;alikafka_pre-cn-i7m2hflj****&quot;,&quot;alikafka_pre-cn-zvp2hsje****&quot;,&quot;alikafka_pre-cn-zvp2kvc9****&quot;]}]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceIds { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABA4A7FD-E10F-45C7-9774-A5236015****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
