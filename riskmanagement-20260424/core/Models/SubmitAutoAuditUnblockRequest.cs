// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class SubmitAutoAuditUnblockRequest : TeaModel {
        /// <summary>
        /// <para>The list of assets.</para>
        /// <remarks>
        /// <para>The array supports up to 50 IP addresses.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;domain&quot;:&quot;&quot;,&quot;ip&quot;:&quot;120.26.29.16&quot;,&quot;assetType&quot;:&quot;EIP&quot;}]</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public string AssetList { get; set; }

        /// <summary>
        /// <para>The auditor.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter. It does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Auditor")]
        [Validation(Required=false)]
        public string Auditor { get; set; }

        /// <summary>
        /// <para>The customer UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1317334647812936</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public string CustomerUid { get; set; }

        /// <summary>
        /// <para>The type of the email to send.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("EmailType")]
        [Validation(Required=false)]
        public string EmailType { get; set; }

        /// <summary>
        /// <para>Specifies whether the email includes an unsubscribe option.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Included.</description></item>
        /// <item><description><b>false</b>: Not included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasUnsubscribe")]
        [Validation(Required=false)]
        public bool? HasUnsubscribe { get; set; }

        /// <summary>
        /// <para>The description of the number of emails to send.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SendCount")]
        [Validation(Required=false)]
        public string SendCount { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Usage instructions</para>
        /// </summary>
        [NameInMap("UseDesc")]
        [Validation(Required=false)]
        public string UseDesc { get; set; }

    }

}
