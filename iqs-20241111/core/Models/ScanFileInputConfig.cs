// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ScanFileInputConfig : TeaModel {
        /// <summary>
        /// <para>The automatic trim.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoCrop")]
        [Validation(Required=false)]
        public string AutoCrop { get; set; }

        /// <summary>
        /// <para>The automatic rotation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoRotate")]
        [Validation(Required=false)]
        public string AutoRotate { get; set; }

    }

}
