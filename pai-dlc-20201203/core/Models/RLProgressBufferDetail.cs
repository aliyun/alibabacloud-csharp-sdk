// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressBufferDetail : TeaModel {
        /// <summary>
        /// <para>已被 trainer 消费的样本数</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Consumed")]
        [Validation(Required=false)]
        public int? Consumed { get; set; }

        /// <summary>
        /// <para>已完成样本数</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public int? Finished { get; set; }

        /// <summary>
        /// <para>已就绪样本数</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Ready")]
        [Validation(Required=false)]
        public int? Ready { get; set; }

        /// <summary>
        /// <para>buffer 标签，即 global batch 序号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public int? Tag { get; set; }

        /// <summary>
        /// <para>目标样本数</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
