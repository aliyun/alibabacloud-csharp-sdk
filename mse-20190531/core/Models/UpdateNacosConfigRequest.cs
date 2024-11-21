// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateNacosConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postoffice</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The list of IP addresses where the beta release of the configuration is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>196.168.XX.XX</para>
        /// </summary>
        [NameInMap("BetaIps")]
        [Validation(Required=false)]
        public string BetaIps { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ky-check-****.yml</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        /// <summary>
        /// <para>The description of the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic configurations</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The encryption key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122wdwe****</para>
        /// </summary>
        [NameInMap("EncryptedDataKey")]
        [Validation(Required=false)]
        public string EncryptedDataKey { get; set; }

        /// <summary>
        /// <para>The name of the group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>resource</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-7pp2a****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The MD5 value of the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>045439703a273a94306422b****</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78b7af66-d15f-4541-b886-11ed81ecb6c0</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-20</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The format of the configuration. Supported formats include TEXT, JSON, XML, and HTML.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
