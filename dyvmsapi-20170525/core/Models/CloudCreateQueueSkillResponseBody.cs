// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateQueueSkillResponseBody : TeaModel {
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
        public CloudCreateQueueSkillResponseBodyData Data { get; set; }
        public class CloudCreateQueueSkillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>创建时间，格式: yyyy-MM-dd HH:mm:ss</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-30 06:12:34</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>企业编号</para>
            /// 
            /// <b>Example:</b>
            /// <para>7122600</para>
            /// </summary>
            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public long? EnterpriseId { get; set; }

            /// <summary>
            /// <para>id</para>
            /// 
            /// <b>Example:</b>
            /// <para>54475</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>队列号</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Qno")]
            [Validation(Required=false)]
            public long? Qno { get; set; }

            /// <summary>
            /// <para>队列id</para>
            /// 
            /// <b>Example:</b>
            /// <para>51937</para>
            /// </summary>
            [NameInMap("QueueId")]
            [Validation(Required=false)]
            public long? QueueId { get; set; }

            /// <summary>
            /// <para>skill的id</para>
            /// 
            /// <b>Example:</b>
            /// <para>48735</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public long? SkillId { get; set; }

            /// <summary>
            /// <para>技能值</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SkillLevel")]
            [Validation(Required=false)]
            public long? SkillLevel { get; set; }

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
        /// <para>9927CD06-C33A-50CC-A9BB-A3427967A66F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
