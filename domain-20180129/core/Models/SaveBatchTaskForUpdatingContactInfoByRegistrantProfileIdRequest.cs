// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest : TeaModel {
        /// <summary>
        /// <para>The contact type to modify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>registrant</b>: The domain name\&quot;s registrant.</para>
        /// </description></item>
        /// <item><description><para><b>admin</b>: The administrative contact for the domain name.</para>
        /// </description></item>
        /// <item><description><para><b>billing</b>: The billing contact.</para>
        /// </description></item>
        /// <item><description><para><b>tech</b>: The technical contact.</para>
        /// </description></item>
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
        /// <para>An array of domain names to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// <para>The language of the error message that is returned if the request fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
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
        /// <para>The ID of the registrant profile. This ID is automatically generated when you create a registrant profile. You can find registrant profile IDs by calling the <a href="https://help.aliyun.com/document_detail/67701.html">QueryRegistrantProfiles</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the transfer lock. This parameter is valid only when <b>ContactType</b> is set to <b>registrant</b>. If enabled, this feature prevents the domain name from being transferred for 60 days after the registrant information is modified.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables the lock, which prevents the domain name from being transferred out.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables the lock, which allows the domain name to be transferred out.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TransferOutProhibited")]
        [Validation(Required=false)]
        public bool? TransferOutProhibited { get; set; }

        /// <summary>
        /// <para>The IP address of the client. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
