// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AlertQuery : TeaModel {
        /// <summary>
        /// <para>Chart name</para>
        /// 
        /// <b>Example:</b>
        /// <para>chartExmaple</para>
        /// </summary>
        [NameInMap("chartTitle")]
        [Validation(Required=false)]
        public string ChartTitle { get; set; }

        /// <summary>
        /// <para>Dashboard ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>dashboardExample</para>
        /// </summary>
        [NameInMap("dashboardId")]
        [Validation(Required=false)]
        public string DashboardId { get; set; }

        /// <summary>
        /// <para>End time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>now</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        /// <summary>
        /// <para>Whether to enable Dedicated SQL</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("powerSqlMode")]
        [Validation(Required=false)]
        public string PowerSqlMode { get; set; }

        /// <summary>
        /// <para>Project name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>projectExample</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>Query and analysis statement</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| select *</description></item>
        /// </list>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Region</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Role ARN</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>Start time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-5m</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        /// <summary>
        /// <para>Store name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>store Example</para>
        /// </summary>
        [NameInMap("store")]
        [Validation(Required=false)]
        public string Store { get; set; }

        /// <summary>
        /// <para>Store type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        /// <summary>
        /// <para>Time span type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Relative</para>
        /// </summary>
        [NameInMap("timeSpanType")]
        [Validation(Required=false)]
        public string TimeSpanType { get; set; }

        /// <summary>
        /// <para>Used by the frontend for specific-scenario alerts</para>
        /// </summary>
        [NameInMap("ui")]
        [Validation(Required=false)]
        public string Ui { get; set; }

    }

}
