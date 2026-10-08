// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForUpdatingContactInfoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to add a transfer-out restriction. This parameter takes effect only when <b>ContactType</b> is <b>registrant</b>. It indicates whether to restrict domain transfer-out for 60 days after the registrant is updated. Default value: <b>false</b>, which means no transfer-out restriction is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AddTransferLock")]
        [Validation(Required=false)]
        public bool? AddTransferLock { get; set; }

        /// <summary>
        /// <para>Contact type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>registrant</b></description></item>
        /// <item><description><b>admin</b></description></item>
        /// <item><description><b>billing</b></description></item>
        /// <item><description><b>tech</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registrant</para>
        /// </summary>
        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// <para>Domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Domain instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S123456789</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
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
        /// <para>Information template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <para>User IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
