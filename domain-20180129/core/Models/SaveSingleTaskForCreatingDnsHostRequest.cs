// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForCreatingDnsHostRequest : TeaModel {
        /// <summary>
        /// <para>DNS name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns1</para>
        /// </summary>
        [NameInMap("DnsName")]
        [Validation(Required=false)]
        public string DnsName { get; set; }

        /// <summary>
        /// <para>Domain instance ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/67712.html">QueryDomainList</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S1234567890</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>List of IP addresses. You can specify up to 13 IP addresses. When specifying multiple IP addresses, pass them as a <b>list</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>218.xx.xx.236</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public List<string> Ip { get; set; }

        /// <summary>
        /// <para>Language of the error message returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese  </description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>User IP address, which can be set to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
