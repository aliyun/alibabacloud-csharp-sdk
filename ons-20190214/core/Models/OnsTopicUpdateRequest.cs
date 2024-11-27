// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance to which the topic belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The read/write mode that you want to configure for the topic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>6</b>: Both read and write operations are allowed.</description></item>
        /// <item><description><b>4</b>: Write operations are forbidden.</description></item>
        /// <item><description><b>2</b>: Read operations are forbidden.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Perm")]
        [Validation(Required=false)]
        public int? Perm { get; set; }

        /// <summary>
        /// <para>The name of the topic that you want to manage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
