// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLJobCheckpointConfig : TeaModel {
        /// <summary>
        /// <para>工作容器内的绝对路径，必须位于可读写的数据源挂载目录内。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/output</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Checkpoint 保存间隔。-1 表示关闭，正整数表示每 N 个训练步保存</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SaveIntervalSteps")]
        [Validation(Required=false)]
        public int? SaveIntervalSteps { get; set; }

    }

}
