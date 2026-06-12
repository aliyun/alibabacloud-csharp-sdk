// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ConsumeProcessor : TeaModel {
        /// <summary>
        /// <para>Processor配置</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ConsumeProcessorConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717171200</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Processor描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>过滤content字段</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Processor名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>字段过滤处理</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Processor ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consume-processor-1</para>
        /// </summary>
        [NameInMap("processorName")]
        [Validation(Required=false)]
        public string ProcessorName { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717171200</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
