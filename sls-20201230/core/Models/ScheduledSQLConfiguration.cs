// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ScheduledSQLConfiguration : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log2log</para>
        /// </summary>
        [NameInMap("dataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-intranet.log.aliyuncs.com</para>
        /// </summary>
        [NameInMap("destEndpoint")]
        [Validation(Required=false)]
        public string DestEndpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-logstore-demo</para>
        /// </summary>
        [NameInMap("destLogstore")]
        [Validation(Required=false)]
        public string DestLogstore { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-demo</para>
        /// </summary>
        [NameInMap("destProject")]
        [Validation(Required=false)]
        public string DestProject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogetlrole</para>
        /// </summary>
        [NameInMap("destRoleArn")]
        [Validation(Required=false)]
        public string DestRoleArn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1712592000</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m-1m</para>
        /// </summary>
        [NameInMap("fromTimeExpr")]
        [Validation(Required=false)]
        public string FromTimeExpr { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public long? MaxRetries { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public long? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enhanced</para>
        /// </summary>
        [NameInMap("resourcePool")]
        [Validation(Required=false)]
        public string ResourcePool { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogetlrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| select *</description></item>
        /// </list>
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source-logstore-demo</para>
        /// </summary>
        [NameInMap("sourceLogstore")]
        [Validation(Required=false)]
        public string SourceLogstore { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>searchQuery</para>
        /// </summary>
        [NameInMap("sqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m</para>
        /// </summary>
        [NameInMap("toTimeExpr")]
        [Validation(Required=false)]
        public string ToTimeExpr { get; set; }

    }

}
