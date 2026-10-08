// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TrimPolicy : TeaModel {
        /// <summary>
        /// <para>Specifies whether to prevent all empty cells from being deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableDeleteEmptyCell")]
        [Validation(Required=false)]
        public bool? DisableDeleteEmptyCell { get; set; }

        /// <summary>
        /// <para>Specifies whether to prevent all duplicate styles from being deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableDeleteRepeatedStyle")]
        [Validation(Required=false)]
        public bool? DisableDeleteRepeatedStyle { get; set; }

        /// <summary>
        /// <para>Specifies whether to prevent unused cell images from being deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableDeleteUnusedPicture")]
        [Validation(Required=false)]
        public bool? DisableDeleteUnusedPicture { get; set; }

        /// <summary>
        /// <para>Specifies whether to prevent unused shapes from being deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableDeleteUnusedShape")]
        [Validation(Required=false)]
        public bool? DisableDeleteUnusedShape { get; set; }

    }

}
