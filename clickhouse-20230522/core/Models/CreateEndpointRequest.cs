// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the new endpoint. The prefix of the ConnectionString parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp100p4q1g9z3****-clickhouse.clickhouseserver.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionPrefix")]
        [Validation(Required=false)]
        public string ConnectionPrefix { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp100p4q1g9z3****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
