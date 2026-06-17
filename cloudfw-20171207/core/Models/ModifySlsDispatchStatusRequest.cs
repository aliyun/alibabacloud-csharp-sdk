// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifySlsDispatchStatusRequest : TeaModel {
        /// <summary>
        /// <para>The key for the log category. Valid values:</para>
        /// <para><b>internet_log</b></para>
        /// <para><b>vpc_firewall_log</b></para>
        /// <para><b>nat_firewall_log</b></para>
        /// <para><b>ipv6_firewall_log</b></para>
        /// <para><b>dns_firewall_log</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet_log</para>
        /// </summary>
        [NameInMap("DispatchValue")]
        [Validation(Required=false)]
        public string DispatchValue { get; set; }

        /// <summary>
        /// <para>Specifies whether to deliver logs. A value of \<c>true\\</c> enables delivery, and \<c>false\\</c> disables it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public bool? EnableStatus { get; set; }

        /// <summary>
        /// <para>The supported filter conditions. Valid values:</para>
        /// <para><b>attack</b></para>
        /// <para><b>acl</b></para>
        /// <para><b>other</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attack,acl</para>
        /// </summary>
        [NameInMap("FilterKeys")]
        [Validation(Required=false)]
        public string FilterKeys { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("NewRegionId")]
        [Validation(Required=false)]
        public string NewRegionId { get; set; }

        /// <summary>
        /// <para>The site to modify. If the log version is 1, leave this parameter empty or set it to \<c>global\\</c>. If the log version is 2, set this parameter to \<c>cn\\</c> or \<c>intl\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

    }

}
