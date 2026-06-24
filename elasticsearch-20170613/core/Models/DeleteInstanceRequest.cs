// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DeleteInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The release type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>immediate: The instance is immediately deleted. After deletion, the system permanently clears all data, and the instance no longer appears in the instance list.</description></item>
        /// <item><description>protective: The instance is frozen for 24 hours before the data is permanently cleared. During this period, the instance still appears in the instance list, and you can choose to <a href="https://help.aliyun.com/document_detail/202195.html">restore the instance</a> or <a href="https://help.aliyun.com/document_detail/202195.html">immediately release it</a>.</description></item>
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
