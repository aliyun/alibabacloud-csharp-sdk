// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class ExportAnnotationsRequest : TeaModel {
        /// <summary>
        /// <para>OSS path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://***-hz-oss.oss-cn-hangzhou.aliyuncs.com/output/</para>
        /// </summary>
        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        /// <summary>
        /// <para>Specifies whether to register the result as a PAI dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Registers the annotation result as a PAI dataset.</description></item>
        /// <item><description>false: Exports the annotation result directly to an OSS folder without registering it as a dataset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RegisterDataset")]
        [Validation(Required=false)]
        public string RegisterDataset { get; set; }

        /// <summary>
        /// <para>Target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PAI</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
