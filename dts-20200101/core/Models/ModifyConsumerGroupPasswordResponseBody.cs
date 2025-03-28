// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyConsumerGroupPasswordResponseBody : TeaModel {
        /// <summary>
        /// <para>The current password of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The username of the consumer group. You can call the <a href="https://help.aliyun.com/document_detail/122886.html">DescribeConsumerGroup</a> operation to query the username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A06B5CFF-9576-4BC1-BE62-A3D43E1F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The new password of the consumer group.</para>
        /// <list type="bullet">
        /// <item><description>A password must contain two or more of the following characters: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>A password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
