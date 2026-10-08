// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest : TeaModel {
        /// <summary>
        /// <para>A list of domain names. If you specify multiple domain names, pass them as a <b>list</b>. Call the <a href="https://help.aliyun.com/document_detail/69362.htm?spm=a2c4g.11186623.0.0.33f4253cSJy3m8">QueryDomainList</a> API to obtain a list of your domain names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public List<string> DomainName { get; set; }

        /// <summary>
        /// <para>The language of error messages returned by the API. Valid values:</para>
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
        /// <para>The registrant profile ID. Call the <a href="https://help.aliyun.com/document_detail/67701.htm?spm=a2c4g.11186623.0.0.33f420daTwRQaO">QueryRegistrantProfiles</a> API to query the registrant profile ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable a 60-day transfer lock on the domain name after its registrant information is updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: Do not apply the lock.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Apply the lock.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TransferOutProhibited")]
        [Validation(Required=false)]
        public bool? TransferOutProhibited { get; set; }

        /// <summary>
        /// <para>The IP address of the user. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
