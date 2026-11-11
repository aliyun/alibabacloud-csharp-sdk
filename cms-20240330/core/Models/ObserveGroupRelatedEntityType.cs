// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupRelatedEntityType : TeaModel {
        /// <summary>
        /// <para>The Chinese name of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RocketMQ Topic</para>
        /// </summary>
        [NameInMap("cnName")]
        [Validation(Required=false)]
        public string CnName { get; set; }

        /// <summary>
        /// <para>The association direction, which is currently fixed as outgoing, indicating that associated entities are searched along the direct outgoing edges of the primary entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outgoing</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The entity domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The English name of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RocketMQ Topic</para>
        /// </summary>
        [NameInMap("enName")]
        [Validation(Required=false)]
        public string EnName { get; set; }

        /// <summary>
        /// <para>The CommonSchema group to which the entity belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs-rocketmq</para>
        /// </summary>
        [NameInMap("entityGroup")]
        [Validation(Required=false)]
        public string EntityGroup { get; set; }

        /// <summary>
        /// <para>The direct outgoing edge relationship, such as use, run_on, calls, or contains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>contains</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>The associated entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs.rocketmq.topic</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The effective CommonSchema version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.14</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
