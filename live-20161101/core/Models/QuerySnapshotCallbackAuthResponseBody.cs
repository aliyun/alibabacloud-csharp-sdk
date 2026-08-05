// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class QuerySnapshotCallbackAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication key for callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourkey</para>
        /// </summary>
        [NameInMap("CallbackAuthKey")]
        [Validation(Required=false)]
        public string CallbackAuthKey { get; set; }

        /// <summary>
        /// <para>Indicates whether authentication for callbacks is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>yes</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>no</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("CallbackReqAuth")]
        [Validation(Required=false)]
        public string CallbackReqAuth { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
