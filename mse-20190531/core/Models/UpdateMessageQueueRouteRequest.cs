// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateMessageQueueRouteRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hkhon1po62@c3df23522baa898</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Specifies whether message canary release is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The filtering side for message canary release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Server</para>
        /// </summary>
        [NameInMap("FilterSide")]
        [Validation(Required=false)]
        public string FilterSide { get; set; }

        /// <summary>
        /// <para>The list of baseline environment labels for MSMQ grayscale rules.</para>
        /// </summary>
        [NameInMap("GrayBaseTags")]
        [Validation(Required=false)]
        public List<string> GrayBaseTags { get; set; }

        /// <summary>
        /// <para>The MSE namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ignored tags for the untagged environments of the application.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
