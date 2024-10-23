// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SourceRocketMQParameters : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ACL</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Tag</para>
        /// </summary>
        [NameInMap("FilterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GID_group1</para>
        /// </summary>
        [NameInMap("GroupID")]
        [Validation(Required=false)]
        public string GroupID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
        /// </summary>
        [NameInMap("InstanceEndpoint")]
        [Validation(Required=false)]
        public string InstanceEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MQ_INST_164901546557****_BAAN****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PrivateNetwork</para>
        /// </summary>
        [NameInMap("InstanceNetwork")]
        [Validation(Required=false)]
        public string InstanceNetwork { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("InstancePassword")]
        [Validation(Required=false)]
        public string InstancePassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sg-hp35r2hc3a3sv8q2****</para>
        /// </summary>
        [NameInMap("InstanceSecurityGroupId")]
        [Validation(Required=false)]
        public string InstanceSecurityGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Cloud_5</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6W0xz2uPfiwp****</para>
        /// </summary>
        [NameInMap("InstanceUsername")]
        [Validation(Required=false)]
        public string InstanceUsername { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-uf6gwtbn6etadpvz7****</para>
        /// </summary>
        [NameInMap("InstanceVSwitchIds")]
        [Validation(Required=false)]
        public string InstanceVSwitchIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-uf6of9452b2pba82c****</para>
        /// </summary>
        [NameInMap("InstanceVpcId")]
        [Validation(Required=false)]
        public string InstanceVpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CONSUME_FROM_TIMESTAMP</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1636597951964</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>myTopic</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
