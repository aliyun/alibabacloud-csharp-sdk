// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class AutomaticWriteOffRequest : TeaModel {
        /// <summary>
        /// <para>The automatic write-off amount. This parameter is required if automatic write-off is enabled. Valid values: 100, 500, and 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AutomaticWriteOffAmount")]
        [Validation(Required=false)]
        public long? AutomaticWriteOffAmount { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic write-off and set the automatic write-off amount. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables automatic write-off and sets the automatic write-off amount.</description></item>
        /// <item><description>false: Disables automatic write-off.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutomaticWriteOffEnabled")]
        [Validation(Required=false)]
        public bool? AutomaticWriteOffEnabled { get; set; }

        /// <summary>
        /// <para>The UID of the customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public long? CustomerUid { get; set; }

        /// <summary>
        /// <para>The language. If this parameter is not specified, English is used by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English.</description></item>
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>ja: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
