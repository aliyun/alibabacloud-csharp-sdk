// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateWhitelistSettingRequest : TeaModel {
        /// <summary>
        /// <para>The ID card number to add to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44018219950810XXXX</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>The certificate ID. The user associated with this authentication is added to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha6d0405f42926084e396e76a037d00</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>The user language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The remarks for the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试白名单。</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000014526</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>antcloudauth</b>: Financial-grade ID Verification.</description></item>
        /// <item><description><b>cloudauthst</b> (discontinued): ID Verification Enhanced Edition.</description></item>
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
        /// <para>The source IP address of the visitor. You do not need to specify this parameter. The system automatically obtains the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.115.63.58</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The number of valid days after the whitelist is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ValidDay")]
        [Validation(Required=false)]
        public int? ValidDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUPER</para>
        /// </summary>
        [NameInMap("WhitelistType")]
        [Validation(Required=false)]
        public string WhitelistType { get; set; }

    }

}
