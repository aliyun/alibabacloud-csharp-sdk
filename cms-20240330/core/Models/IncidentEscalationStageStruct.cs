// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationStageStruct : TeaModel {
        /// <summary>
        /// <para>联系人列表</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public List<IncidentContactStruct> Contact { get; set; }

        /// <summary>
        /// <para>周期通知统计次数</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("cycleNotifyCount")]
        [Validation(Required=false)]
        public int? CycleNotifyCount { get; set; }

        /// <summary>
        /// <para>周期通知时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("cycleNotifyTime")]
        [Validation(Required=false)]
        public int? CycleNotifyTime { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>负责处理生产环境告警的主负责人</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>有效时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-05T00:00:00Z</para>
        /// </summary>
        [NameInMap("effectTime")]
        [Validation(Required=false)]
        public string EffectTime { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>运维团队</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>阶段指数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("stageIndex")]
        [Validation(Required=false)]
        public int? StageIndex { get; set; }

        /// <summary>
        /// <para>时区</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>等待进入下一阶段的时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("waitToNextStageTime")]
        [Validation(Required=false)]
        public int? WaitToNextStageTime { get; set; }

    }

}
