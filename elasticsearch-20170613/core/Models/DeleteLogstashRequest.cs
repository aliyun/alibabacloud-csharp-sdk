// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DeleteLogstashRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The type of the release operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>immediate: The cluster is immediately deleted when it is released. After the cluster is deleted, the data stored in the cluster is deleted, and the system removes the cluster from the Logstash cluster list.</description></item>
        /// <item><description>protective: The cluster is released 24 hours later. During the period of 24 hours, you can still find the cluster in the Logstash cluster list, and <a href="https://help.aliyun.com/document_detail/202205.html">restore the cluster</a> or <a href="https://help.aliyun.com/document_detail/160591.html">immediately release the cluster</a>. After 24 hours elapse, the data stored in the cluster is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>protective</para>
        /// </summary>
        [NameInMap("deleteType")]
        [Validation(Required=false)]
        public string DeleteType { get; set; }

    }

}
