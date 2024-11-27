// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the details of the consumer group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The details of the consumer group are queried. You can obtain details from the <b>ConsumerConnectionInfoList</b> and <b>DetailInTopicList</b> response parameters.</description></item>
        /// <item><description><b>false</b>: The details of the consumer group are not queried. The values of the <b>ConsumerConnectionInfoList</b> and <b>DetailInTopicList</b> response parameters are empty. This value is the default value of the Detail parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public bool? Detail { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group whose details you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_group_id</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the consumer group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the information about thread stack traces. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information about thread stack traces is queried. You can obtain the information from the <b>Jstack</b> response parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to obtain the information about thread stack traces, make sure that the <b>Detail</b> parameter in the request is set to <b>true</b>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The information about thread stack traces is not queried. The value of the <b>Jstack</b> response parameter is empty. This value is the default value of the NeedJstack parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedJstack")]
        [Validation(Required=false)]
        public bool? NeedJstack { get; set; }

    }

}
