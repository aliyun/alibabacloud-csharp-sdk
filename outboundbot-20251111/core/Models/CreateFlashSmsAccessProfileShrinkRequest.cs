// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateFlashSmsAccessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access configuration.</para>
        /// </summary>
        [NameInMap("AccessProfile")]
        [Validation(Required=false)]
        public string AccessProfileShrink { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The provider ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Uincall: Beijing Youyin Communication Co., Ltd.</description></item>
        /// <item><description>ChuangLan: Beijing Chuanglan Yunzhi Information Co., Ltd.</description></item>
        /// <item><description>ChinaMobile: China Mobile.</description></item>
        /// <item><description>ShangHaiTianNan: Shanghai Tiannan.</description></item>
        /// <item><description>HeDao: Galexes.</description></item>
        /// <item><description>DySms: Alibaba Communication.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Uincall</para>
        /// </summary>
        [NameInMap("ProviderId")]
        [Validation(Required=false)]
        public string ProviderId { get; set; }

    }

}
