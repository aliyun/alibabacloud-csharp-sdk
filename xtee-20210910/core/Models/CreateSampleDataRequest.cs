// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleDataRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The encryption type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: all encryption</description></item>
        /// <item><description><b>LABEL</b>: label encryption</description></item>
        /// <item><description><b>NONE</b>: no encryption.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LABEL</para>
        /// </summary>
        [NameInMap("encryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>注册样本</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The specified risk value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>black</para>
        /// </summary>
        [NameInMap("riskValue")]
        [Validation(Required=false)]
        public string RiskValue { get; set; }

        /// <summary>
        /// <para>The scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHONE</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The storage path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/de/sample/3dc2spspHKq4G3YI9d08</para>
        /// </summary>
        [NameInMap("storePath")]
        [Validation(Required=false)]
        public string StorePath { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
