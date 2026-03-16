// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class QuickAddTaskRequest : TeaModel {
        /// <summary>
        /// <para>坐席组ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AgentGroupId")]
        [Validation(Required=false)]
        public long? AgentGroupId { get; set; }

        /// <summary>
        /// <para>外呼时间</para>
        /// </summary>
        [NameInMap("CallTimeList")]
        [Validation(Required=false)]
        public List<QuickAddTaskRequestCallTimeList> CallTimeList { get; set; }
        public class QuickAddTaskRequestCallTimeList : TeaModel {
            /// <summary>
            /// <para>外呼时间</para>
            /// </summary>
            [NameInMap("CallTime")]
            [Validation(Required=false)]
            public List<string> CallTime { get; set; }

        }

        /// <summary>
        /// <para>外呼时间:精确到分钟.如果两个字段都存在值，以该字段为准。建议用该字段，精确到分钟, 08:31-12:05 13:33-19:00 则传[[&quot;08:31&quot;,&quot;12:05&quot;][&quot;13:33&quot;,&quot;19:00&quot;]]；默认为[[&quot;08:00&quot;,&quot;20:00&quot;]]</para>
        /// 
        /// <b>Example:</b>
        /// <para>[[&quot;08:31&quot;,&quot;12:05&quot;][&quot;13:33&quot;,&quot;19:00&quot;]]；默认为[[&quot;08:00&quot;,&quot;20:00&quot;]]</para>
        /// </summary>
        [NameInMap("CallTimeStrList")]
        [Validation(Required=false)]
        public List<QuickAddTaskRequestCallTimeStrList> CallTimeStrList { get; set; }
        public class QuickAddTaskRequestCallTimeStrList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;08:00&quot;,&quot;20:00&quot;]</para>
            /// </summary>
            [NameInMap("CallTime")]
            [Validation(Required=false)]
            public List<string> CallTime { get; set; }

        }

        /// <summary>
        /// <para>任务名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>555555555555</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>被复制任务ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReferenceTaskId")]
        [Validation(Required=false)]
        public long? ReferenceTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>curl 2W7xHcIl.popscan.xaliyun.com</para>
        /// </summary>
        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1708643153842856</para>
        /// </summary>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>短信模板ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SmsTemplateId")]
        [Validation(Required=false)]
        public long? SmsTemplateId { get; set; }

        /// <summary>
        /// <para>任务启动日期</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-04-30</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>话术模板ID,如果不传则使用被复制任务的话术模板</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>话术模板类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>1：单模版；2：智能话术策略模板。不填默认1。</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public long? TemplateType { get; set; }

    }

}
