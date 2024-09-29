// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryAppTopologyRequest : TeaModel {
        /// <summary>
        /// <para>The application type</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRACE</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The database domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxx.mysql.rds.aliyuncs.com:3306</para>
        /// </summary>
        [NameInMap("Db")]
        [Validation(Required=false)]
        public string Db { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orders</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671952708499</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Filters { get; set; }

        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>Log on to the <b>ARMS console</b>. In the left-side navigation pane, choose <b>Browser Monitoring</b> &gt; <b>Browser Monitoring</b>. On the Browser Monitoring page, click the name of an application. The URL in the address bar contains the process ID (PID) of the application. The PID is indicated in the pid=xxx format. The PID is usually percent encoded as xxx%40xxx. You must modify this value to remove the percent encoding. For example, if the PID in the URL is eb4zdose6v%409781be0f44d\<em>\</em>\<em>\</em>, you must replace %40 with an at sign (@) to obtain eb4zdose6v@9781be0f44d\<em>\</em>\<em>\</em>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atc889zkcf@d8deedfa9bf****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>RPC interface name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/eventCenter</para>
        /// </summary>
        [NameInMap("Rpc")]
        [Validation(Required=false)]
        public string Rpc { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1595568910000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The type kind of topology.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm_apps_v2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
