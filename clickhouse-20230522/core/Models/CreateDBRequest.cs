// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateDBRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp100p4q1g9z3****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain lowercase letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name can be up to 64 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para> An underscore (_) is counted as two characters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb001</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

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
