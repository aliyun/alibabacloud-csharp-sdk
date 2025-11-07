// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateWhitelistSettingRequest : TeaModel {
        /// <summary>
        /// <para>ID number to be whitelisted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44018219950810XXXX</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>Certificate ID, used for whitelisting this specific authenticated user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha6d0405f42926084e396e76a037d00</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>User language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Whitelist remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试白名单。</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000014526</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>Service type:</para>
        /// <list type="bullet">
        /// <item><description><b>antcloudauth</b>: Financial-grade real-person authentication.</description></item>
        /// <item><description><b>cloudauthst</b> (discontinued): Enhanced real-person authentication.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Visitor\&quot;s source IP address. No need to fill in, the system will automatically obtain it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.115.63.58</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Number of valid days after creating the whitelist.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ValidDay")]
        [Validation(Required=false)]
        public int? ValidDay { get; set; }

    }

}
