// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class EnableSqlConcurrencyControlRequest : TeaModel {
        /// <summary>
        /// <para>The duration within which the SQL throttling rule takes effect. Unit: seconds.</para>
        /// <remarks>
        /// <para> The throttling rule takes effect only within this duration.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ConcurrencyControlTime")]
        [Validation(Required=false)]
        public long? ConcurrencyControlTime { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para> You must specify the instance ID only if your database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent SQL statements. Set this parameter to a positive integer.</para>
        /// <remarks>
        /// <para> When the number of concurrent SQL statements that contain the specified keywords reaches this upper limit, the throttling rule is triggered.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public long? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>The keywords that are used to identify the SQL statements that need to be throttled.</para>
        /// <remarks>
        /// <para> If you specify multiple SQL keywords, separate them with tildes (~). If the number of concurrent SQL statements that contain all the specified SQL keywords reaches the specified upper limit, the throttling rule is triggered.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>call<del>open</del>api<del>test</del>4<del>from</del>POP</para>
        /// </summary>
        [NameInMap("SqlKeywords")]
        [Validation(Required=false)]
        public string SqlKeywords { get; set; }

        /// <summary>
        /// <para>The type of the SQL statements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SELECT</b></description></item>
        /// <item><description><b>UPDATE</b></description></item>
        /// <item><description><b>DELETE</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

    }

}
