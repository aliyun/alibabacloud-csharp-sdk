// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class SetVsStreamsNotifyUrlConfigRequest : TeaModel {
        /// <summary>
        /// <para>The primary key associated with the playback domain name. This key generates authenticated URLs.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/464513.html">DescribeVsDomainConfigs</a> operation to query the AuthKey value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ocs*****ace</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>no_auth</b> (disabled)</para>
        /// </description></item>
        /// <item><description><para><b>type_a</b> (method A)</para>
        /// </description></item>
        /// <item><description><para><b>type_b</b> (method B)</para>
        /// </description></item>
        /// <item><description><para><b>type_c</b> (method C)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>type_a</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>Your accelerated domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The URL to which live stream information is pushed.</para>
        /// <remarks>
        /// <para>This URL must start with http\:// or https\://.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx.com/xx">http://xxx.com/xx</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
