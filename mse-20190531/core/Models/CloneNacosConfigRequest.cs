// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneNacosConfigRequest : TeaModel {
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
        /// <para>The configuration items that you want to clone. The value of this parameter is the combination of the values of the dataId and group parameters. Separate multiple configuration items with commas (,).</para>
        /// </summary>
        [NameInMap("DataIds")]
        [Validation(Required=false)]
        public string DataIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The list of configuration IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>253661,253662</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        [Obsolete]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The ID of the destination namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-i7m25igg403</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The policy used when a write conflict occurs.</para>
        /// <list type="bullet">
        /// <item><description>ABORT</description></item>
        /// <item><description>SKIP</description></item>
        /// <item><description>OVERWRITE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>be821963-6d48-4ea5-9910-6057d****</para>
        /// </summary>
        [NameInMap("OriginNamespaceId")]
        [Validation(Required=false)]
        public string OriginNamespaceId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OVERWRITE</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The IDs of configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08be4b5d-2d1c-4e6e-aa85-83b9****</para>
        /// </summary>
        [NameInMap("TargetNamespaceId")]
        [Validation(Required=false)]
        public string TargetNamespaceId { get; set; }

    }

}
