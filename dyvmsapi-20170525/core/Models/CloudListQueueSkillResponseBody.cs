// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListQueueSkillResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudListQueueSkillResponseBodyData Data { get; set; }
        public class CloudListQueueSkillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>返回数据</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudListQueueSkillResponseBodyDataList> List { get; set; }
            public class CloudListQueueSkillResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>创建时间，格式: yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20 10:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>企业编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public long? EnterpriseId { get; set; }

                /// <summary>
                /// <para>queueSkill关系表中id</para>
                /// 
                /// <b>Example:</b>
                /// <para>93</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>26</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public long? Qno { get; set; }

                /// <summary>
                /// <para>队列id</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public long? QueueId { get; set; }

                /// <summary>
                /// <para>skill的id</para>
                /// 
                /// <b>Example:</b>
                /// <para>44</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public long? SkillId { get; set; }

                /// <summary>
                /// <para>技能值</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SkillLevel")]
                [Validation(Required=false)]
                public long? SkillLevel { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
