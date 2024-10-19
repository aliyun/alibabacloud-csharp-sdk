// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddTrafficSpecialControlRequest : TeaModel {
        /// <summary>
        /// <para>The security token included in the WebSocket request header. The system uses this token to authenticate the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fa876ffb-caab-4f0a-93b3-3409f2fa5199</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the app or Alibaba Cloud account. Specify this parameter based on the value of the <b>SpecialType</b> parameter. You can view your account ID on the <a href="https://account.console.aliyun.com/?spm=a2c4g.11186623.2.15.3f053654YpMPwo#/secure">Account Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3382463</para>
        /// </summary>
        [NameInMap("SpecialKey")]
        [Validation(Required=false)]
        public string SpecialKey { get; set; }

        /// <summary>
        /// <para>The type of the special throttling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>APP</b></description></item>
        /// <item><description><b>USER</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("SpecialType")]
        [Validation(Required=false)]
        public string SpecialType { get; set; }

        /// <summary>
        /// <para>The ID of the specified throttling policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf123456</para>
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        /// <summary>
        /// <para>The special throttling value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("TrafficValue")]
        [Validation(Required=false)]
        public int? TrafficValue { get; set; }

    }

}
