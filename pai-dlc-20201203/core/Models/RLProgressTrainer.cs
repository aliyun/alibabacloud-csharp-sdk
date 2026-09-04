// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressTrainer : TeaModel {
        /// <summary>
        /// <para>micro-batch 进度</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Micro")]
        [Validation(Required=false)]
        public RLProgressMicro Micro { get; set; }

        /// <summary>
        /// <para>当前 mini batch 序号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MiniIdx")]
        [Validation(Required=false)]
        public int? MiniIdx { get; set; }

        /// <summary>
        /// <para>mini-batch 总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NumMinibatches")]
        [Validation(Required=false)]
        public int? NumMinibatches { get; set; }

        /// <summary>
        /// <para>参数同步状态</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public RLProgressSync Sync { get; set; }

    }

}
