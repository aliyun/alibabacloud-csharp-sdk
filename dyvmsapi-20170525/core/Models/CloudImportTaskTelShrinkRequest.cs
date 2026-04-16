// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudImportTaskTelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>座席接听时自动在双侧播放开场白语音，指定语音变量值；企业语音库里的语音变量值</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("BridgeVoicePath")]
        [Validation(Required=false)]
        public string BridgeVoicePath { get; set; }

        /// <summary>
        /// <para>座席接听时自动在双侧播放开场白语音类型；1. 公共语音库；2. 企业语音库，静态话术； 3. 企业语音库，动态话术（座席号），传bridgeVoicePath后生效，默认为3</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BridgeVoiceType")]
        [Validation(Required=false)]
        public long? BridgeVoiceType { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>批次Id；传此值表示在批次中增加号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>666</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// <para>是否自动启动任务；0:不自动启动 1:自动启动，默认为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ImportTelAutoStart")]
        [Validation(Required=false)]
        public long? ImportTelAutoStart { get; set; }

        /// <summary>
        /// <para>是否排重；0.不排重 1.任务内排重 2.导入号码排重 3.批次内排重，默认为1。注：任务内排重与批次内排重不能同时支持，如果中途切换，则从本次切换开始进行排重。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsRepeat")]
        [Validation(Required=false)]
        public long? IsRepeat { get; set; }

        /// <summary>
        /// <para>批次名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>优先级；默认0，值越大越优先，最大999999</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>任务Id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>任务号码列表；CtiLinkTaskTel中只有Tel是必选字段，长度大小不超过8MB 注：获取导入失败明细，需配置<a href="../%E5%AD%97%E6%AE%B5%E5%AE%9A%E4%B9%89/%E6%8E%A8%E9%80%81%E5%8F%98%E9%87%8F%E5%92%8C%E5%80%BC/%E9%A2%84%E6%B5%8B%E5%A4%96%E5%91%BC%E5%AF%BC%E5%85%A5%E5%8F%B7%E7%A0%81%E5%A4%B1%E8%B4%A5%E6%8E%A8%E9%80%81%E5%8F%98%E9%87%8F.md">事件推送</a></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskTelList")]
        [Validation(Required=false)]
        public string TaskTelListShrink { get; set; }

    }

}
