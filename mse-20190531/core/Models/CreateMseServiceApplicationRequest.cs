// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateMseServiceApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bsd-xxyp-open-goods-server</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>The programming language of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JAVA</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The version of the Microservices Engine (MSE) cluster to be activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mse_pro: Professional Edition.</description></item>
        /// <item><description>mse_dev: Developer Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse_pro</para>
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

        /// <summary>
        /// <para>The region where the cluster is located, including but not limited to:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Hangzhou</description></item>
        /// <item><description>cn-beijing: Beijing</description></item>
        /// <item><description>cn-shanghai: Shanghai</description></item>
        /// <item><description>cn-zhangjiakou: Zhangjiakou</description></item>
        /// <item><description>cn-shenzhen: Shenzhen</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Sentinel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SentinelEnable")]
        [Validation(Required=false)]
        public string SentinelEnable { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edasmsc</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Switch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SwitchEnable")]
        [Validation(Required=false)]
        public string SwitchEnable { get; set; }

    }

}
