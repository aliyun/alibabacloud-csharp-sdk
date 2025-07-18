// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SasRasp20240727.Models
{
    public class DescribeAttacksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67e283ee866f097cf07d****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("AttackHostId")]
        [Validation(Required=false)]
        public string AttackHostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sql</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://aliyun.com">http://aliyun.com</a></para>
        /// </summary>
        [NameInMap("AttackUrl")]
        [Validation(Required=false)]
        public string AttackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1737216000000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>block</para>
        /// </summary>
        [NameInMap("HandlerType")]
        [Validation(Required=false)]
        public string HandlerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lshm-sec-waf-new-38</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("RaspType")]
        [Validation(Required=false)]
        public string RaspType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Remote")]
        [Validation(Required=false)]
        public string Remote { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727281449756</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2d14556b77cf1bf7c696e010aaa*****</para>
        /// </summary>
        [NameInMap("UnionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
