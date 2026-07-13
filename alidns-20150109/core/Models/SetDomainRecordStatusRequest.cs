// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDomainRecordStatusRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the DNS record. You can call the <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomainrecords?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomainRecords</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9********</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The status of the DNS record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enable</b>: Enables parsing.</para>
        /// </description></item>
        /// <item><description><para><b>Disable</b>: Pauses parsing.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
