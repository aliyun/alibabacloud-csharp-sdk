// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class BindInstance2VpcResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xu6666-mkdd-test.cn-hangzhou.vpc.ots.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The connection endpoint for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.<b>.</b>*.34</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The ID of the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E734979F-5A44-5993-9CE5-C23103576923</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
